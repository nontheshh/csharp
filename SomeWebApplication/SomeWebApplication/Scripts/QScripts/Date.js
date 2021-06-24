function getDateFromDotNet(datetime) {
    return new Date(parseInt(datetime.substr(6)));
}

function getDateTimeString(date) {
    return date.toLocaleDateString() + " | " + date.toLocaleTimeString();
}