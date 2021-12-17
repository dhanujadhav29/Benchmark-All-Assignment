var Product = /** @class */ (function () {
    function Product(pid, pname, amount) {
        this.pid = pid;
        this.pname = pname;
        this.amount = amount;
    }
    Product.prototype.display = function () {
        console.log("Pid  Pname  Amount");
        console.log(this.pid + "   " + this.pname + "   " + this.amount);
    };
    Product.prototype.calDiscount = function (amount, qty, discount) {
        var ans = this.amount * this.qty;
        this.totaldiscount = (ans * this.discount) / 100;
        return this.totaldiscount;
    };
    return Product;
}());
var ob2 = new Product(1, 'pen', 20);
console.log("Total discount is :" + ob2.calDiscount(20, 4, 5));
ob2.display();
