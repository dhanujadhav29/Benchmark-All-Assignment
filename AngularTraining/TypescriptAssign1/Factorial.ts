function fact(no:number){
let sum=1;
for(let i=no;i>0;i--){
    sum=sum*i;
}
console.log("Factorial is :"+sum);

}

fact(5);