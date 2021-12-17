var Student = /** @class */ (function () {
    function Student(roll, name, marks, total) {
        this.roll = roll;
        this.name = name;
        this.marks = marks;
        this.total = total;
    }
    Student.prototype.calResult = function (total, marks) {
        this.percent = (marks * 100) / total;
        if (this.percent >= 75) {
            return "you got A Grade";
        }
        else if (this.percent >= 60 && this.percent < 75) {
            return "you got B Grade";
        }
        else if (this.percent >= 50 && this.percent < 60) {
            return "you got C Grade";
        }
        else if (this.percent >= 40 && this.percent < 50) {
            return "you got Pass Grade";
        }
        else if (this.percent < 35) {
            return "you are Fail";
        }
    };
    Student.prototype.display = function () {
        console.log("Roll  Name  Marks   Percentage");
        console.log(this.roll + "   " + this.name + "   " + this.marks + "   " + this.percent);
    };
    return Student;
}());
var ob = new Student(1, 'Dhanu', 50, 100);
ob.display();
console.log(ob.calResult(100, 50));
