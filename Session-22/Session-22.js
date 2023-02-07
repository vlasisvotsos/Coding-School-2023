/* task 1 */
function reversion(str){
    reversedStr =""
    for (var i = str.length - 1; i >= 0; i--) {
        reversedStr += str[i];
    }
    return reversedStr;
}
/* task 2 */
function checkPalidrome(str){
    for(let i=0;i<str.length/2;i++){
        if(str[i]!=str[str.length-i-1]){
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
function incrementation(str){
    if(isNaN(str[str.length-1])){
        str[str.length-1] += 1;
    }else{
        str =+1;
    }
    return str;
}