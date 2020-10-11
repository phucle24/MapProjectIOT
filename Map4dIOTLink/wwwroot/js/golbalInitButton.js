var globalModule = {}
globalModule.initButton = function (id, onclickEvent) {
    $("#" + id).on("click", onclickEvent);
}