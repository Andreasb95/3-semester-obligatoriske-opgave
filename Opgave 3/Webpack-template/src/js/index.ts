let inputElement: HTMLInputElement = <HTMLInputElement> document.getElementById("input");
let selectorElement: HTMLSelectElement = <HTMLSelectElement> document.getElementById("Selector");
let buttonElement: HTMLButtonElement = <HTMLButtonElement> document.getElementById("button")
buttonElement.addEventListener("click",changeword);

function changeword(): void{
    let selector: string = selectorElement.value;
    let input: string = inputElement.value;

    let paragraphElement: HTMLParagraphElement = <HTMLParagraphElement> document.getElementById("output")

    if(selector == "uppercase"){
        let result = input.toUpperCase();
        paragraphElement.innerHTML = "Uppercase: " + result;
    }

    else{
        let result = input.toLowerCase();
        paragraphElement.innerHTML = "lowercase " + result;
    }
}