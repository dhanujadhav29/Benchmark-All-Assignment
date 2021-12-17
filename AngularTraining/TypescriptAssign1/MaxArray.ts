function Max(arr:any){

    var max=arr[0];
    var i=1;
    while(i<=arr.length){
           
            if(arr[i]>max)
             max=arr[i];
             i++;  
            
        }
        return max; 
   }



var a=new Array(1,6,2,9,29,24);
console.log("Max is :"+Max(a));