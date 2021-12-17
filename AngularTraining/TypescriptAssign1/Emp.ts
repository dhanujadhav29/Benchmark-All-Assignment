class Emp{
    id:number;
    name:string;
    salary:number;
    ga:number;
    hra:number;
    da:number;

    constructor(id:number,name:string,salary:number){
     this.id=id;
     this.name=name;
     this.salary=salary;
    }

    calsalary(salary:number):number{
     if(this.salary<20000){
        this.ga=((this.salary*80)/100)+((this.salary*20)/100);
        return this.ga;
     }else if(this.salary>20000 && this.salary<35000){
        this.ga=((this.salary*25)/100)+((this.salary*70)/100);
        return this.ga;
     }
    }

    display(){
        console.log("Id  Name");
        console.log(this.id+"   "+this.name);
    }
}

var ob1=new Emp(10,'Atharva',30000);
console.log("Gross Salary is : "+ob1.calsalary(30000));
ob1.display();