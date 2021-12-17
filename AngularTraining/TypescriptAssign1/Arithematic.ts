function calculate(a:number,b:number,op:string)
{
  if(op.charAt[0]=="+"){
        console.log("Addition is "+(a+b));
  }
  else if(op.charAt[0]=="-"){
        return a-b;
  }
  else if(op.charAt[0]=="/"){
    return a/b;
  }
  else if(op.charAt[0]=="*"){
    return a*b;
  }else{
      console.log("Error");
  }
}

calculate(4,2,'+');