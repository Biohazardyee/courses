# E-Commerce API with JWT Authentication

Express.js API for managing products and shopping cart with JWT-based authentication and bcrypt password hashing.

## Setup

```bash
npm install
npm start
```

Server: `http://localhost:3000`

## � Authentication System

This API uses **JWT (JSON Web Tokens)** for authentication with bcrypt password hashing.

### Test Users

| Email               | Password      | Roles       |
| ------------------- | ------------- | ----------- |
| `admin@example.com` | `password123` | admin, user |
| `user@example.com`  | `password123` | user        |

---

## 🔑 Authentication Flow

### Step 1: Login to get JWT Token

**POST** `/login`

**Headers:**

```
Content-Type: application/json
```

**Body:**

```json
{
  "email": "admin@example.com",
  "password": "password123"
}
```

**Success Response:**

```json
{
  "success": true,
  "token": "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9...",
  "user": {
    "id": 1,
    "email": "admin@example.com",
    "roles": ["admin", "user"]
  }
}
```

### Step 2: Use JWT Token for Protected Routes

**Headers for all protected routes:**

```
Authorization: Bearer YOUR_JWT_TOKEN_HERE
Content-Type: application/json
```

⚠️ **Important:** Include "Bearer " before your token with a space!

---

## 📦 Products (`/articles`) - Protected Routes

| Method | URL             | Body                                   | Description         | Required Role |
| ------ | --------------- | -------------------------------------- | ------------------- | ------------- |
| GET    | `/articles`     | -                                      | Get all products    | user          |
| GET    | `/articles/:id` | -                                      | Get single product  | user          |
| POST   | `/articles`     | `{"name": "Product", "price": 99.99}`  | Create product      | admin         |
| PUT    | `/articles/:id` | `{"name": "Updated", "price": 129.99}` | Update product      | admin         |
| DELETE | `/articles/:id` | -                                      | Delete product      | admin         |
| DELETE | `/articles`     | -                                      | Delete all products | admin         |

## 🛒 Cart (`/cart`) - Protected Routes

| Method | URL         | Body                              | Description            | Required Role |
| ------ | ----------- | --------------------------------- | ---------------------- | ------------- |
| GET    | `/cart`     | -                                 | View cart with balance | user          |
| POST   | `/cart`     | `{"productId": 1, "quantity": 2}` | Add to cart            | user          |
| PUT    | `/cart/:id` | `{"quantity": 5}`                 | Update cart item       | user          |
| DELETE | `/cart/:id` | -                                 | Remove cart item       | user          |
| DELETE | `/cart`     | -                                 | Clear cart             | user          |

---

## 🧪 Testing with Postman

### Complete Test Flow

1. **Login as Admin**

   - POST `/login` with admin credentials
   - Copy the JWT token from response

2. **Create a Product** (Admin only)

   - POST `/articles`
   - Headers: `Authorization: Bearer YOUR_TOKEN`, `Content-Type: application/json`
   - Body: `{"name": "Test Product", "price": 29.99}`

3. **View All Products**

   - GET `/articles`
   - Headers: `Authorization: Bearer YOUR_TOKEN`

4. **Add Product to Cart**

   - POST `/cart`
   - Headers: `Authorization: Bearer YOUR_TOKEN`, `Content-Type: application/json`
   - Body: `{"productId": 1, "quantity": 2}`

5. **View Cart with Balance**
   - GET `/cart`
   - Headers: `Authorization: Bearer YOUR_TOKEN`

### Testing Authentication Errors

- **No token:** Access any protected route without Authorization header
- **Invalid token:** Use malformed or expired token
- **Wrong format:** Use token without "Bearer " prefix
- **Wrong credentials:** Login with incorrect email/password

---

## 🚨 Error Responses

| Status | Error                                       | Cause                                  |
| ------ | ------------------------------------------- | -------------------------------------- |
| 401    | `Authorization header missing or malformed` | Missing token or wrong format          |
| 401    | `Invalid email or password`                 | Wrong login credentials                |
| 403    | `Invalid password or email credentials`     | Password doesn't match                 |
| 403    | `Insufficient privileges`                   | User role can't access admin endpoints |
| 404    | Product/item not found                      | Invalid ID in URL                      |
| 500    | Server error                                | Internal server error                  |

---

## 🔧 Development Notes

- **Environment Variables:** JWT secret stored in `.env` file
- **Password Security:** Bcrypt with salt rounds = 10
- **Token Format:** Bearer token in Authorization header
- **Route Protection:** Middleware applied after login route
- **User Storage:** File-based JSON storage (`data/users.json`)
