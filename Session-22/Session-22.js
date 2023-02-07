/* task 1 */
function reversion(str){
    reversedStr =""
    for (var i = str.length - 1; i >= 0; i--) {
        reversedStr += str[i];
    }
    return reversedStr;
}
