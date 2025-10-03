# E-Commerce API Documentation

Express.js API for managing products and shopping cart with security middleware.

## Setup

```bash
npm install
npm start
```

Server: `http://localhost:3000`

## 🔒 Authentication

**Required Header for ALL requests:**
```
value: user
```

**Note:** Some endpoints may require admin privileges. If you receive a 403 Forbidden response with proper authentication, you may need admin access.

---

## 📦 Products (`/articles`)

| Method | URL             | Body                                   | Description         | Access Level |
| ------ | --------------- | -------------------------------------- | ------------------- | ------------ |
| GET    | `/articles`     | -                                      | Get all products    | User         |
| GET    | `/articles/:id` | -                                      | Get single product  | User         |
| POST   | `/articles`     | `{"name": "Product", "price": 99.99}`  | Create product      | Admin*       |
| PUT    | `/articles/:id` | `{"name": "Updated", "price": 129.99}` | Update product      | Admin*       |
| DELETE | `/articles/:id` | -                                      | Delete product      | Admin*       |
| DELETE | `/articles`     | -                                      | Delete all products | Admin*       |

## 🛒 Cart (`/cart`)

| Method | URL         | Body                              | Description            | Access Level |
| ------ | ----------- | --------------------------------- | ---------------------- | ------------ |
| GET    | `/cart`     | -                                 | View cart with balance | User         |
| POST   | `/cart`     | `{"productId": 1, "quantity": 2}` | Add to cart            | User         |
| PUT    | `/cart/:id` | `{"quantity": 5}`                 | Update cart item       | User         |
| DELETE | `/cart/:id` | -                                 | Remove cart item       | User         |
| DELETE | `/cart`     | -                                 | Clear cart             | User         |

**\*Admin endpoints:** These operations modify product data and may require additional admin privileges depending on security middleware configuration.

---

## Postman Headers

**For all requests:**

```
value: user
```

**For POST/PUT requests, also add:**

```
Content-Type: application/json
```

## Quick Test Flow

1. `POST /articles` - Create a product
2. `GET /articles` - Verify product exists
3. `POST /cart` - Add product to cart (use productId from step 1)
4. `GET /cart` - View cart with calculated balance

## Error Responses

- `403`: Missing `value: user` header or insufficient admin privileges
- `400`: Invalid data
- `404`: Product/item not found

**Note:** Product creation, modification, and deletion operations (marked with *) may require admin access beyond the basic user authentication.
