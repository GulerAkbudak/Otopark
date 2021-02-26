$(document).ready(function () {
    var original = $("#radiogroup").clone(true);

    function onChange(e) {
        e.preventDefault();
        var radioGroup = $("#radiogroup"),
            clone = original.clone(true);

        radioGroup.data("kendoRadioGroup");
        radioGroup.replaceWith(clone);
        initRadioGroup();
    }