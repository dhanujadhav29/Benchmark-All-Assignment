var Emp = /** @class */ (function () {
    function Emp(id, name, salary) {
        this.id = id;
        this.name = name;
        this.salary = salary;
    }
    Emp.prototype.calsalary = function (salary) {
        if (this.salary < 20000) {
            this.ga = ((this.salary * 80) / 100) + ((this.salary * 20) / 100);
            return this.ga;
        }
        else if (this.salary > 20000 && this.salary < 35000) {
            this.ga = ((this.salary * 25) / 100) + ((this.salary * 70) / 100);
            return this.ga;
        }
    };
    Emp.prototype.display = function () {
        console.log("Id  Name");
        console.log(this.id + "   " + this.name);
    };
    return Emp;
}());
var ob1 = new Emp(10, 'Atharva', 30000);
console.log("Gross Salary is : " + ob1.calsalary(30000));
ob1.display();
