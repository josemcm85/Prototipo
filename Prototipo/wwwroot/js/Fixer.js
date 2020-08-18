//// set endpoint and your API key
//endpoint = 'converter';
//access_key = '0305dd081d7a4e21c63b9414e0f6dc78';

//// define from currency, to currency, and amount
//from = 'EUR';
//to = 'CRC';
//amount = '1';

//// execute the conversion using the "convert" endpoint:
//$.ajax({
//    url: 'http://data.fixer.io/api/' + endpoint + '?access_key=' + access_key + '&from=' + from + '&to=' + to + '&amount=' + amount,
//    dataType: 'jsonp',
//    success: function (json) {

//        // access the conversion result in json.result
//        alert(json.result);
//        console.log(json.result);
//        document.getElementById("moneda").innerHTML = json.result;
//    }
//});

//function Exchange()
//{

//    var xmlhttp = new XMLHttpRequest();
//    var url = 'https://api.exchangeratesapi.io/latest?symbols=USD';
//    xmlhttp.open("GET", url, true);
//    xmlhttp.send();
//    xmlhttp.onreadystatechange = function () {
//        if (xmlhttp.readyState == 4 && xmlhttp.status == 400) {
//            var result = xmlhttp.responseText;
//            alert(result);
//            console.log(result);
//            document.getElementById("moneda").innerHTML = result;
//        }
//    }
//}


function Exchange()
{

    var xmlhttp = new XMLHttpRequest;
    var url = '//api.exchangeratesapi.io/latest?symbols=USD';
    xmlhttp.open("GET", url);
    xmlhttp.send();
    xmlhttp.onreadystatechange = function () {
        if (xmlhttp.readyState == 4) {
            var result = xmlhttp.responseText;
            var jsResult = JSON.parse(result);
            var unidadVenta = 1 / jsResult.rates["USD"];
            unidadVenta = unidadVenta.toFixed(2);
            var unidadCompra = jsResult.rates["USD"];
            unidadCompra = unidadCompra.toFixed(2);

            console.log(result);

            document.getElementById("unidadVenta").innerHTML = "$" + unidadVenta;
            document.getElementById("unidadCompra").innerHTML = "$" + unidadCompra;

            document.getElementById("unidadVentaCliente").innerHTML = "$1 = €" + unidadVenta;
            document.getElementById("unidadCompraCliente").innerHTML = "€1 = $" + unidadCompra;
        }
    }

    }

function ExchangeCliente() {

    var xmlhttp = new XMLHttpRequest;
    var url = '//api.exchangeratesapi.io/latest?symbols=USD';
    xmlhttp.open("GET", url);
    xmlhttp.send();
    xmlhttp.onreadystatechange = function () {
        if (xmlhttp.readyState == 4) {
            var result = xmlhttp.responseText;
            var jsResult = JSON.parse(result);
            var unidadVenta = 1 / jsResult.rates["USD"];
            unidadVenta = unidadVenta.toFixed(2);
            var unidadCompra = jsResult.rates["USD"];
            unidadCompra = unidadCompra.toFixed(2);

            console.log(result);

            document.getElementById("unidadVentaCliente").innerHTML = "$1 = €" + unidadVenta;
            document.getElementById("unidadCompraCliente").innerHTML = "€1 = $" + unidadCompra;
        }
    }

}