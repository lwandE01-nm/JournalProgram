# Journal Program 
# Foundation Program Design Document

## Program 1: Abstraction with YouTube Videos

### What it does
Models a YouTube-like system with videos and comments.

### Classes

#### Video
- Attributes: title, author, length, comments
- Methods: add_comment(), get_number_of_comments(), display_video_info()

#### Comment
- Attributes: user_name, text
- Methods: display_comment()

#### VideoLibrary
- Attributes: videos (list)
- Methods: add_video(), display_all_videos()

### Flow
Create videos → add comments → store in library → display content

### Diagram
VideoLibrary → Video → Comment


---

## Program 2: Encapsulation with Online Ordering

### What it does
Simulates an online ordering system with products, customers, and shipping.

### Classes

#### Product
- Attributes: name, product_id, price, quantity
- Methods: calculate_total_price()

#### Customer
- Attributes: name
- Methods: display_customer_info()

#### Address
- Attributes: street, city, province, country
- Methods: display_address()

#### Order
- Attributes: products, customer, address
- Methods: add_product(), calculate_total(), get_packing_label(), get_shipping_label()

### Flow
Create customer + address → add products → calculate total → print labels

### Diagram
Customer + Address → Order → Product(s)
