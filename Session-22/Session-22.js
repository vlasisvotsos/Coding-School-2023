/* task 1 */
function reversion(str1){
    reversedStr =""
    for (var i = str1.length - 1; i >= 0; i--) {
        reversedStr += str1[i];
    }
    return reversedStr;
}
/* task 2 */
function checkPalidrome(str2){
    for(let i=0;i<str2.length/2;i++){
        if(str2[i]!=str2[str2.length-i-1]){
            return false;
        }
    }
    return true;
}
/* task 3 */
/* task 4 */
function myltiply(a,b){
    return a*b;
}
/* task 5 */
function incrementation(str5){
    if(isNaN(str5[str5.length-1])){
        str5[str5.length-1] += 1;
    }else{
        str5 =+1;
    }
    return str5;
}