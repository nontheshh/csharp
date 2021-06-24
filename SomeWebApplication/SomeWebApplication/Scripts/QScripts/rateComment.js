class CommentRating {
    constructor(urlGet, urlRate) {
        this.urlGet = urlGet;
        this.urlRate = urlRate;
    }

    getCommentRating(commentId, rateElement) {
        $.ajax({
            type: "GET",
            url: this.urlGet,
            contentType: "application/json; charset=utf-8",
            data: { commentId: commentId },
            dataType: "text",
            success: function (data) {
                console.log('Success: getCommentRating');
                rateElement.innerText = data;
            },
            error: function (data) {
                console.error(data);
            }
        });
    }

    rateComment(commentId, type, ratingElement) {
        $.ajax({
            type: "GET",
            url: this.urlRate,
            contentType: "application/json; charset=utf-8",
            data: { commentId: commentId, ratingTypeString: type },
            success: (data) => {
                console.log('Success: rateComment');
                this.getCommentRating(commentId, ratingElement)
            },
            error: function (data) {
                console.error("doesnt matter ", data);
            }
        });
    }
}
