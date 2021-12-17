function calculate(a, b, op) {
    if (op.charAt[0] == "+") {
        console.log("Addition is " + (a + b));
    }
    else if (op.charAt[0] == "-") {
        return a - b;
    }
    else if (op.charAt[0] == "/") {
        return a / b;
    }
    else if (op.charAt[0] == "*") {
        return a * b;
    }
    else {
        console.log("Error");
    }
}
console.log(calculate(4, 2, '+'));
