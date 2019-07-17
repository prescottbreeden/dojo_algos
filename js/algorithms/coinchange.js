function change(cents) {
    var dollars = Math.floor(cents/100)
    cents = cents % 100;
    var quarters = Math.floor(cents/25)
    cents = cents % 25;
    var dimes = Math.floor(cents/10)
    cents = cents % 10;
    var nickels = Math.floor(cents/5);
    cents = cents % 5;
    var result = {
        dollars: dollars,
        quarters: quarters,
        dimes: dimes,
        nickels: nickels,
        pennies: cents
    }
    console.log(result)
}

change(120)
change(160)
change(15)