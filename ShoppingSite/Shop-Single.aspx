﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Shop-Single.aspx.cs" Inherits="ShoppingSite.Shop_Single" %>

<!DOCTYPE html>
<html lang="en">

<head>
    <title>Online shoppy E-Commerce website</title>

    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">

    <link href="https://fonts.googleapis.com/css?family=Rubik:400,700" rel="stylesheet">
    <link rel="stylesheet" href="fonts/icomoon/style.css">

    <link rel="stylesheet" href="css/bootstrap.min.css">
    <link rel="stylesheet" href="css/magnific-popup.css">
    <link rel="stylesheet" href="css/jquery-ui.css">
    <link rel="stylesheet" href="css/owl.carousel.min.css">
    <link rel="stylesheet" href="css/owl.theme.default.min.css">


    <link rel="stylesheet" href="css/aos.css">

    <link rel="stylesheet" href="css/style.css">

</head>

<body>

    <div class="site-wrap">


        <div class="site-navbar bg-white py-2 position-relative">

            <div class="search-wrap">
                <div class="container">
                    <a href="#" class="search-close js-search-close"><span class="icon-close2"></span></a>
                    <form action="#" method="post">
                        <input type="text" class="form-control" placeholder="Search keyword and hit enter...">
                    </form>
                </div>
            </div>

            <div class="container">
                <div class="d-flex align-items-center justify-content-between">
                    <div class="logo">
                        <div class="site-logo">
                            <a href="Shop-Single.aspx" class="js-logo-clone">Online shoppy</a>
                        </div>
                    </div>
                    <div class="main-nav d-none d-lg-block">
                        <nav class="site-navigation text-right text-md-center" role="navigation">
                            <ul class="site-menu js-clone-nav d-none d-lg-block">
                                <li class="has-children active">
                                    <a href="Products?UID=<%=Request.QueryString["UID"]%>&ID=1">Collection</a>
                                    <ul class="dropdown">
                                        <li><a href="Products?UID=<%=Request.QueryString["UID"]%>&ID=1">Men's Fashion</a></li>
                                        <li><a href="Products?UID=<%=Request.QueryString["UID"]%>&ID=2">Women's Fashion</a></li>
                                        <li><a href="Products?UID=<%=Request.QueryString["UID"]%>&ID=3">Sports, Fitness & Outdoor  </a></li>
                                         <li><a href="Products?UID=<%=Request.QueryString["UID"]%>&ID=4">Books Collections</a></li>
                                         <li><a href="Products?UID=<%=Request.QueryString["UID"]%>&ID=5">Beauty, Health & Daily Needs</a></li>
                                    </ul>
                                </li>

                                <li><a href="Products?UID=<%=Request.QueryString["UID"]%>&ID=1">Shop</a></li>

                            </ul>
                        </nav>
                    </div>
                    <div class="icons">
                        <a href="#" class="icons-btn d-inline-block"><span class="icon-heart-o"></span></a>
                        <a href="Cart.aspx?UID=<%=Request.QueryString["UID"]%>" class="icons-btn d-inline-block bag">
                            <span class="icon-shopping-bag"></span>
                        </a>
                        <a href="#" class="icons-btn d-inline-block"><span class="icon-user-o"></span></a>
                         <a href="Login.aspx">Logout</a>  
                        <a href="#" class="site-menu-toggle js-menu-toggle ml-3 d-inline-block d-lg-none"><span class="icon-menu"></span></a>
                    </div>
                </div>
            </div>
        </div>

        <div class="bg-light py-3">
            <div class="container">
                <div class="row">
                    <div class="col-md-12 mb-0"><a href="Shop-Single.aspx">Home</a> <span class="mx-2 mb-0">/</span> <a href="Products?UID=<%=Request.QueryString["UID"]%>&ID=1">Shop</a> <span class="mx-2 mb-0">/</span> <strong class="text-black">The Shoe</strong></div>
                </div>
            </div>
        </div>

        <div class="site-section">
            <div class="container">
                <div class="row">
                    <asp:Repeater runat="server" ID="rptProduct">
                          <ItemTemplate>
                    <div class="col-md-6">
                        
                        <div class="border">
                            <%# GetImage(Eval("imageurl")) %>
                        </div>
                    </div>
                    <div class="col-md-6">
                        <input type="hidden" id="userId" value="<%=Request.QueryString["UID"]%>">
                        <input type="hidden" id="productId" value="<%# Eval("productId") %>">
                        <h2 class="text-black"><%# Eval("productName") %></h2>
                        <p><%# Eval("productDetails") %></p>
                        <p><strong class="text-primary h4">$<%# Eval("Price") %></strong></p>

                        <div class="mb-1 d-flex">
                            <label for="option-sm" class="d-flex mr-3 mb-3">
                <span class="d-inline-block mr-2" style="top:0px; position: relative;"><input type="radio" id="option-sm" name="shop-sizes"></span> <span class="d-inline-block text-black">Small</span>
              </label>
                            <label for="option-md" class="d-flex mr-3 mb-3">
                <span class="d-inline-block mr-2" style="top:0px; position: relative;"><input type="radio" id="option-md" name="shop-sizes"></span> <span class="d-inline-block text-black">Medium</span>
              </label>
                            <label for="option-lg" class="d-flex mr-3 mb-3">
                <span class="d-inline-block mr-2" style="top:0px; position: relative;"><input type="radio" id="option-lg" name="shop-sizes"></span> <span class="d-inline-block text-black">Large</span>
              </label>
                            <label for="option-xl" class="d-flex mr-3 mb-3">
                <span class="d-inline-block mr-2" style="top:0px; position: relative;"><input type="radio" id="option-xl" name="shop-sizes"></span> <span class="d-inline-block text-black"> Extra Large</span>
              </label>
                        </div>
                        <div class="mb-5">
                            <div class="input-group mb-3" style="max-width: 120px;">
                                <div class="input-group-prepend">
                                    <button class="btn btn-outline-primary js-btn-minus" type="button">&minus;</button>
                                </div>
                                <input type="text" name="count" id="count" class="form-control text-center" value="1" placeholder="" aria-label="Example text with button addon" aria-describedby="button-addon1">
                                <div class="input-group-append">
                                    <button class="btn btn-outline-primary js-btn-plus" type="button">&plus;</button>
                                </div>
                            </div>

                        </div>
                        <input name="addCard" id="addCard" class="btn btn-primary rounded-0 btn-block" type="button" value="Add To Cart" >

                     </ItemTemplate>
                      </asp:Repeater>
                    </div>
                </div>
            </div>
        </div>

        <div class="site-section">
            <div class="container">
                <div class="row">
                    <div class="title-section text-center col-12">
                        <h2 class="text-uppercase">More Products</h2>
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-12 block-3 products-wrap">
                        <div class="nonloop-block-3 owl-carousel">

                            <div class="product">
                                <a href="Shop-Single.aspx" class="item">
                                    <img src="images/product_1.jpg" alt="Image" class="img-fluid">
                                    <div class="item-info">
                                        <h3>The Shoe</h3>
                                        <span class="collection d-block">Summer Collection</span>
                                        <strong class="price">$9.50</strong>
                                    </div>
                                </a>
                            </div>

                            <div class="product">
                                <a href="Shop-Single.aspx" class="item">
                                    <span class="tag">Sale</span>
                                    <img src="images/product_2.jpg" alt="Image" class="img-fluid">
                                    <div class="item-info">
                                        <h3>Marc Jacobs Bag</h3>
                                        <span class="collection d-block">Summer Collection</span>
                                        <strong class="price">$9.50 <del>$30.00</del></strong>
                                    </div>
                                </a>
                            </div>

                            <div class="product">
                                <a href="Shop-Single.aspx" class="item">
                                    <img src="images/product_3.jpg" alt="Image" class="img-fluid">
                                    <div class="item-info">
                                        <h3>The Belt</h3>
                                        <span class="collection d-block">Summer Collection</span>
                                        <strong class="price">$9.50</strong>
                                    </div>
                                </a>
                            </div>

                            <div class="product">
                                <a href="Shop-Single.aspx" class="item">
                                    <img src="images/product_1.jpg" alt="Image" class="img-fluid">
                                    <div class="item-info">
                                        <h3>The Shoe</h3>
                                        <span class="collection d-block">Summer Collection</span>
                                        <strong class="price">$9.50</strong>
                                    </div>
                                </a>
                            </div>

                            <div class="product">
                                <a href="Shop-Single.aspx" class="item">
                                    <span class="tag">Sale</span>
                                    <img src="images/product_2.jpg" alt="Image" class="img-fluid">
                                    <div class="item-info">
                                        <h3>Marc Jacobs Bag</h3>
                                        <span class="collection d-block">Summer Collection</span>
                                        <strong class="price">$9.50 <del>$30.00</del></strong>
                                    </div>
                                </a>
                            </div>

                            <div class="product">
                                <a href="Shop-Single.aspx" class="item">
                                    <img src="images/product_3.jpg" alt="Image" class="img-fluid">
                                    <div class="item-info">
                                        <h3>The Belt</h3>
                                        <span class="collection d-block">Summer Collection</span>
                                        <strong class="price">$9.50</strong>
                                    </div>
                                </a>
                            </div>

                        </div>
                    </div>
                </div>
            </div>
        </div>



        <footer class="site-footer custom-border-top">
            <div class="container">
                <div class="row">
                    <div class="col-md-6 col-lg-4 mb-4 mb-lg-0">

                        <div class="block-7">
                            <h3 class="footer-heading mb-4">About Us</h3>
                            <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Eius quae reiciendis distinctio voluptates sed dolorum excepturi iure eaque, aut unde.</p>
                        </div>
                        <div class="block-7">
                            <form action="#" method="post">
                                <label for="email_subscribe" class="footer-heading">Subscribe</label>
                                <div class="form-group">
                                    <input type="text" class="form-control py-4" id="email_subscribe" placeholder="Email">
                                    <input type="submit" class="btn btn-sm btn-primary" value="Send">
                                </div>
                            </form>
                        </div>
                    </div>
                    <div class="col-lg-4 ml-auto mb-5 mb-lg-0">
                        <div class="row">
                            <div class="col-md-12">
                                <h3 class="footer-heading mb-4">Quick Links</h3>
                            </div>
                            <div class="col-md-6 col-lg-4">
                                <ul class="list-unstyled">
                                    <li><a href="#">Sell online</a></li>
                                    <li><a href="#">Features</a></li>
                                    <li><a href="#">Shopping cart</a></li>
                                    <li><a href="#">Store builder</a></li>
                                </ul>
                            </div>

                        </div>
                    </div>

                    <div class="col-md-6 col-lg-4">
                        <div class="block-5 mb-5">
                            <h3 class="footer-heading mb-4">Contact Info</h3>
                            <ul class="list-unstyled">
                                <li class="address">203 Fake St. Mountain View, California, USA</li>
                                <li class="phone"><a href="tel://23923929210">+2 123456789</a></li>
                                <li class="email">emailaddress@domain.com</li>
                            </ul>
                        </div>


                    </div>
                </div>
                <div class="row pt-5 mt-5 text-center">
                    <div class="col-md-12">
                        <p>
                            Copyright &copy; > All rights reserved
                        </p>
                    </div>

                </div>
            </div>
        </footer>
    
     
    <script src="js/jquery-3.3.1.min.js"></script>
    <script src="js/jquery-ui.js"></script>
    <script src="js/popper.min.js"></script>
    <script src="js/bootstrap.min.js"></script>
    <script src="js/owl.carousel.min.js"></script>
    <script src="js/jquery.magnific-popup.min.js"></script>
    <script src="js/aos.js"></script>

    <script src="js/main.js"></script>
    <script>


        $('input[name = "addCard"]').click(function (e) {
           
           
            
            var count = document.getElementById("count").value;
            var productId = document.getElementById("productId").value;
            var userId = document.getElementById("userId").value;

            $.ajax({
                type: "POST",
                url: 'Shop-Single.aspx/AddCard',
                data: "{'productId':'" + productId + "','count':'" + count + "','userId':'" + userId + "'}",
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (response) {
                    window.location = "Cart.aspx?UID=" + userId;
                },
                failure: function (response) {
                    //alert(response.d);
                },

            });
        }
        );


    </script>
</body>

</html>