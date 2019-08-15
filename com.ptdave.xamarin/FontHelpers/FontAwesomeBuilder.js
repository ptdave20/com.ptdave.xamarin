function camelize(str) {
    return str.replace(/(?:^\w|[A-Z]|\b\w)/g, function (word, index) {
        return index == 0 ? word.toLowerCase() : word.toUpperCase();
    }).replace(/\s+/g, '');
}

function jsUcfirst(string) {
    return string.charAt(0).toUpperCase() + string.slice(1);
}

var names = [];
var csharp = [];
var out = "";
var icons = document.getElementsByClassName('icon');
for (const icon of icons) {
    const name = icon.getElementsByTagName('dd')[0].innerText;
    const unicode = icon.getElementsByTagName('dd')[1].innerText;

    var obj = { name: name, unicode: unicode };
    names.push(obj);
    var camel = name;
    while (true) {
        if (camel.indexOf("-") > -1) {
            camel = camel.replace("-", " ");
        } else {
            break;
        }
    }
    camel = camelize(camel);
    camel = jsUcfirst(camel);
    var cs = "public const string " + camel + " = \"\\u" + unicode + "\";\n";
    out = out + cs;
    csharp.push(cs);
}

console.log(out);
