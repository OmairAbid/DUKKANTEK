# DUKKANTEK

Using Clean Architecture, DDD, SQL server, EF Core for the database provider, .Net 6

1) API - To Get Count the number of products sold, damaged and inStock
/api/product/get-product-status-count

we hit this end point to check products count by product status.

2) To Change the status of a product
/api/product/{id}

we hit end point to change the status of product

3) To Sell a product
/api/basket

we hit end point to sell a product and add it to a basket.
