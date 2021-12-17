class Product{

    pid: number;
    pname: string;
    amount:number;
    qty:number;
    discount:number;
    totaldiscount : number;

    constructor(pid:number,pname:string,amount:number){
     this.pid=pid;
     this.pname=pname;
     this.amount=amount;
    }

    display(){
       console.log("Pid Pname Amount");
       console.log(this.pid+"   "+this.pname+"   "+this.amount);
    }


    calDiscount(amount:number,qty:number,discount:number):number{
     var ans=this.amount*this.qty;
     this.totaldiscount=(ans*this.discount)/100;
     return this.totaldiscount;
    }
}

var ob2=new Product(1,'pen',20);

console.log("Total discount is :"+ob2.calDiscount(20,4,5));
ob2.display();
