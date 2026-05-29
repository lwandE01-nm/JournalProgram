# Online Ordering System (Encapsulation)

## Overview
This program simulates an online ordering system using object-oriented programming principles.

## Classes

### Product
- name
- product_id
- price
- quantity  
- Method: calculate_total_price()

### Customer
- name  
- Method: display_customer_info()

### Address
- street, city, province, country  
- Method: display_address()

### Order
- products (list)
- customer
- address  
- Methods:
  - add_product()
  - calculate_total()
  - get_packing_label()
  - get_shipping_label()

## Purpose
This project demonstrates **encapsulation** by grouping related data and behavior inside classes.

## Flow
Customer + Address → Order → Products → Total + Labels
