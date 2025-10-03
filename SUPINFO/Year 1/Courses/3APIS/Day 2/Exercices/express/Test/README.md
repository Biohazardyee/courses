# E-Commerce API Documentation

Express.js API for managing products and shopping cart with security middleware.

## Setup

```bash
npm install
npm start
```

Server: `http://localhost:3000`

## 🔒 Authentication

**Required Headers:**
- **User access:** `value: user`
- **Admin access:** `value: admin` (can do everything users can + admin operations)

---

## 📦 Products (`/articles`)

| Method | URL             | Body                                   | Description         | Access Level |
| ------ | --------------- | -------------------------------------- | ------------------- | ------------ |
| GET    | `/articles`     | -                                      | Get all products    | User/Admin   |
| GET    | `/articles/:id` | -                                      | Get single product  | User/Admin   |
| POST   | `/articles`     | `{"name": "Product", "price": 99.99}`  | Create product      | Admin only   |
| PUT    | `/articles/:id` | `{"name": "Updated", "price": 129.99}` | Update product      | Admin only   |
| DELETE | `/articles/:id` | -                                      | Delete product      | Admin only   |
| DELETE | `/articles`     | -                                      | Delete all products | Admin only   |

## 🛒 Cart (`/cart`)

| Method | URL         | Body                              | Description            | Access Level |
| ------ | ----------- | --------------------------------- | ---------------------- | ------------ |
| GET    | `/cart`     | -                                 | View cart with balance | User/Admin   |
| POST   | `/cart`     | `{"productId": 1, "quantity": 2}` | Add to cart            | User/Admin   |
| PUT    | `/cart/:id` | `{"quantity": 5}`                 | Update cart item       | User/Admin   |
| DELETE | `/cart/:id` | -                                 | Remove cart item       | User/Admin   |
| DELETE | `/cart`     | -                                 | Clear cart             | User/Admin   |

---

## Postman Headers

**For user requests:**
```
value: user
```

**For admin requests:**
```
value: admin
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

- `403`: Missing authentication header or insufficient privileges
  - Use `value: user` for basic access
  - Use `value: admin` for product management
- `400`: Invalid data
- `404`: Product/item not found
