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