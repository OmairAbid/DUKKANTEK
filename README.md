# DUKKANTEK

Using Clean Architecture, DDD, SQL server, EF Core for the database provider, .Net 6

1) API - Count the number of products sold, damaged and inStock
/api/Product/GetProductsCountbyStatus

we hit this end point to check products count by product status.

2) Change the status of a product
/api/Product/{id}

we hit end point to change the status of product

3) Sell a product
/api/Basket

we hit end point to sell a product and add it to basket.
