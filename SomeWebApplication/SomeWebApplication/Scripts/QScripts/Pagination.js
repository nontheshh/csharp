class Pagination {
    constructor(settings) {
        this.data = null;
        this.curPage = 1;
        this.qtPages = 0;
        this.qtPageBtns = settings['qtPageBtns'];
        this.id = settings['id'];
        this.url = settings['url'];
        this.dataWrapperId = settings['dataWrapperId'];

        this.buildContentCallback = settings['buildContentCallback'];
    }

    getData() {
        $.ajax({
            type: "GET",
            url: this.url,
            contentType: "application/json; charset=utf-8",
            data: { bookId: this.id, page: this.curPage },
            dataType: "json",
            success: (data) => {
                console.log('Success: getData');

                this.data = JSON.parse(data['data']);
                this.qtPages = data['qtPages'];

                this.buildContentCallback(this.data);
                this.buildPageButtons();
            },
            error: (data) => {
                console.error(data);
            }
        });
    }

    buildPageButtons() {
        const wrapper = document.getElementById('pagination-wrapper');
        wrapper.innerHTML = '';

        let maxLeft = (this.curPage - Math.floor(this.qtPageBtns / 2));
        let maxRight = (this.curPage + Math.floor(this.qtPageBtns / 2));

        if (maxLeft < 1) {
            maxLeft = 1;
            maxRight = this.qtPageBtns;
        }
        if (maxRight > this.qtPages) {
            maxLeft = this.qtPages - (this.qtPageBtns);
            maxRight = this.qtPages;
            if (maxLeft < 1) {
                maxLeft = 1;
            }
        }

        for (let page = maxLeft; page <= maxRight; page++) {
            wrapper.innerHTML += `<button value="${page}" class="page btn btn-sm btn-info">${page}</button>`;
        }

        if (this.curPage != 1) {
            wrapper.innerHTML = `<button value="1" class="page btn btn-sm btn-info">First</button>` + wrapper.innerHTML;
        }

        if (this.curPage == this.qtPages && this.qtPages != 1) {
            wrapper.innerHTML += `<button value="${this.qtPages}" class="page btn btn-sm btn-info">Last</button>`;
        }

        $('.page').on('click', (e) => {
            $(`#${this.dataWrapperId}`).empty();
            this.curPage = Number($(e.target).val());
            this.getData();
        });
    }
}
   