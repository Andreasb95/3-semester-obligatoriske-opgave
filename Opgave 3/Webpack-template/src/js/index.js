var inputElement = document.getElementById("input");
var selectorElement = document.getElementById("Selector");
var buttonElement = document.getElementById("button");
buttonElement.addEventListener("click", changeword);
function changeword() {
    var selector = selectorElement.value;
    var input = inputElement.value;
    var paragraphElement = document.getElementById("output");
    if (selector == "uppercase") {
        var result = input.toUpperCase();
        paragraphElement.innerHTML = "Uppercase: " + result;
    }
    else {
        var result = input.toLowerCase();
        paragraphElement.innerHTML = "lowercase " + result;
    }
}
