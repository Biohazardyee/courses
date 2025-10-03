// /articles -> GET
// /articles/id -> GET
// /articles/id -> DELETE
// /articles/id -> POST

// /cart -> POST
// /cart/pay -> 

// pseudocode

articles = []
cart = []

function getArticles() {
    method: "GET";
    endpoint: "/articles";

    for (var i = 0; i < articles.length; i++) {
        return articles[i];
    }
}

function displayArticleById() {
    method: "GET";
    endpoint: "/articles/id";

    return articleId;
}

function deleteArticle(id) {
    method: "DELETE";
    endpoint: "/articles/id";

    articles.slice(id)
    getArticles();
}

function addArticle(id, name, price) {
    method: "PUT";
    endpoint: "/articles";

    articles.append(id, name, price)
    return articles
}

function addArticleToCart() {
    method: "PUT";
    endpoint: "/cart"

    if (buttonPressed = true) {
        cart.append(article[i])

        for (var i = 0; i < cart.length; i++) {
            let price = 0;
            price += cart[i].price;
            return cart[i.name, i.id, i.price];
        }
    }
}

function payForArticles(){
    method: "DELETE"
    endpoint: "/articles"

    if (hasPaid){
        cart = []
        price = 0
    }
}