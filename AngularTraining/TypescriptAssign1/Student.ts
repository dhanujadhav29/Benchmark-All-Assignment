class Student{

    roll : number;
    name : string;
    marks: number;
    total : number;
    percent : number;

   constructor(roll:number,name:string,marks:number,total:number){
     this.roll=roll;
     this.name=name;
     this.marks=marks;
     this.total=total;
   }

   calResult(total:number,marks:number):string{
    this.percent=(marks*100)/total;
    if(this.percent>=75){
        return "you got A Grade";

    }else if(this.percent>=60 && this.percent <75){
        return "you got B Grade";

    }else if(this.percent>=50 && this.percent<60){
        return "you got C Grade";

    }else if(this.percent>=40 && this.percent<50){
        return "you got Pass Grade";

    }else if(this.percent<35){
        return "you are Fail";
    }

   }


   display():void{
       console.log("Roll  Name  Marks   Percentage");
       console.log(this.roll+"   "+this.name+"   "+this.marks+"   "+this.percent);
   }
}

var ob=new Student(1,'Dhanu',50,100);
console.log(ob.calResult(100,50));

ob.display();