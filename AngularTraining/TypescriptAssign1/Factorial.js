function fact(no) {
    var sum = 1;
    for (var i = no; i > 0; i--) {
        sum = sum * i;
    }
    console.log("Factorial is :" + sum);
}
fact(5);
