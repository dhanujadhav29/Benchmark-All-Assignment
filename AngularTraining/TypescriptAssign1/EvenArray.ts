function Even(a:any){

    var sum=0;
    for(var i=0;i<a.length;i++){
       if(a[i]%2==0){
         sum=sum+a[i];
       }
      
    }
    return sum;
}

var a=new Array(4,5,2,6,7,9);
console.log("Even Sum of Array is :"+Even(a));