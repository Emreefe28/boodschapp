function isFloatNumber(e, t) {
    var n;
    var r;
    if (navigator.appName == "Microsoft Internet Explorer" || navigator.appName == "Netscape") {
        n = t.keyCode;
        r = 1;
        if (navigator.appName == "Netscape") {
            n = t.charCode;
            r = 0;
        }
    } else {
        n = t.charCode;
        r = 0;
    }
    if (r == 1) {
        if (!(n >= 48 && n <= 57 || n == 46)) {
            t.returnValue = false;
        }
    } else {
        if (!(n >= 48 && n <= 57 || n == 0 || n == 46)) {
            t.preventDefault();
        }
    }
}