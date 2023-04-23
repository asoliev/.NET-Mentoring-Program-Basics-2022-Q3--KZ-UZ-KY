function task1() {
    let text = 'I can eat bananas all day';
    let start = text.indexOf('bananas');
    let len = 'bananas'.length;
    let slice = text.slice(start, start + len);
    let upper = slice.toUpperCase();
    alert(upper);
}
function task2() {
    const cars = ["Saab", "Volvo", "BMW"];

    //-get "BMW" value 
    const idx = cars.indexOf("BMW");
    console.group(cars[idx]);

    //-change the first item of cars 
    cars[0] = "Subaru";
    console.log(cars);

    //-remove last item in the array 
    cars.pop();
    console.log(cars);

    //-add "Audi" to the array 
    cars.push("Audi");
    console.log(cars);

    //-splice "Volvo" and "BMW" 
    cars.splice(0, 0, "Volvo", "BMW");
    console.log(cars);
}