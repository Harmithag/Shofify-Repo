<%@ Page Title="" Language="C#" AutoEventWireup="true" CodeBehind="Products.aspx.cs" Inherits="ShoppingSite.Products" %>

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
                            <a href="Products?UID=<%=Request.QueryString["UID"]%>&ID=1" class="js-logo-clone">Online shoppy</a>
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
                    <div class="col-md-12 mb-0"><a href="Products?UID=<%=Request.QueryString["UID"]%>&ID=1">Home</a> <span class="mx-2 mb-0">/</span> <strong class="text-black">Shop</strong></div>
                </div>
            </div>
        </div>

        <div class="site-section">
            <div class="container">

                <div class="row mb-5">
                    <div class="col-lg-9 order-2 order-lg-1">

                        <div class="row align">
                            <div class="col-md-12 mb-5">
                                <div class="float-md-left">
                                    <h2 class="text-black h5">Shop All</h2>
                                </div>
                                <div class="d-flex">
                                    
                                </div>
                            </div>
                        </div>
                        <div class="row mb-5">
                            <div class="products-wrap border-top-0">
                                <div class="container-fluid">
                                    <div class="row no-gutters products">
                                        <asp:Repeater runat="server" ID="rptProductList">
                          <ItemTemplate>
                             <div class="col-6 col-md-6 col-lg-6">
                                  <td><a href="Shop-Single?UID=<%=Request.QueryString["UID"]%>&ID=<%# Eval("productId") %>" class="d-flex"> <%# GetImage(Eval("imageurl")) %> </a></td>
                                  <td> <span class="collection d-block"><%# Eval("productDetails") %></span></td>
                                  <td> <strong class="price">$<%# Eval("Price") %> <del>$30.00</del></strong></td>
                              </div>
                          </ItemTemplate>
                      </asp:Repeater>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-md-12 text-center">
                                <div class="site-block-27">
                                    <ul>
                                        <li><a href="#">&lt;</a></li>
                                        <li class="active"><span>1</span></li>
                                        <li><a href="#">2</a></li>
                                        <li><a href="#">3</a></li>
                                        <li><a href="#">4</a></li>
                                        <li><a href="#">5</a></li>
                                        <li><a href="#">&gt;</a></li>
                                    </ul>
                                </div>
                            </div>
                        </div>
                    </div>

                    <div class="col-lg-3 order-1 order-lg-2 mb-5 mb-lg-0">
                        <div class="border p-4 mb-4">
                            <h3 class="mb-3 h6 text-uppercase text-black d-block">Categories</h3>
                            <ul class="list-unstyled mb-0">
                                <li class="mb-1"><a href="Products?UID=<%=Request.QueryString["UID"]%>&ID=1" class="d-flex"><span>Men's Fashion</span> <span class="text-black ml-auto">(2,220)</span></a></li>
                                <li class="mb-1"><a href="Products?UID=<%=Request.QueryString["UID"]%>&ID=2" class="d-flex"><span>Women's Fashion</span> <span class="text-black ml-auto">(2,550)</span></a></li>
                                <li class="mb-1"><a href="Products?UID=<%=Request.QueryString["UID"]%>&ID=3" class="d-flex"><span>Sports, Fitness & Outdoor  </span> <span class="text-black ml-auto">(2,124)</span></a></li>
                                <li class="mb-1"><a href="Products?UID=<%=Request.QueryString["UID"]%>&ID=4" class="d-flex"><span>Books Collections</span> <span class="text-black ml-auto">(2,124)</span></a></li>
                                <li class="mb-1"><a href="Products?UID=<%=Request.QueryString["UID"]%>&ID=5" class="d-flex"><span>Beauty, Health & Daily Needs</span> <span class="text-black ml-auto">(2,124)</span></a></li>


                            </ul>
                        </div>

                        <div class="border p-4 mb-4">
                            <div class="mb-4">
                                <h3 class="mb-3 h6 text-uppercase text-black d-block">Filter by Price</h3>
                                <div id="slider-range" class="border-primary"></div>
                                <input type="text" name="text" id="amount" class="form-control border-0 pl-0 bg-white" disabled="" />
                            </div>

                            <div class="mb-4">
                                <h3 class="mb-3 h6 text-uppercase text-black d-block">Size</h3>
                                <label for="s_sm" class="d-flex">
                  <input type="checkbox" id="s_sm" class="mr-2 mt-1"> <span class="text-black">Small (2,319)</span>
                </label>
                                <label for="s_md" class="d-flex">
                  <input type="checkbox" id="s_md" class="mr-2 mt-1"> <span class="text-black">Medium (1,282)</span>
                </label>
                                <label for="s_lg" class="d-flex">
                  <input type="checkbox" id="s_lg" class="mr-2 mt-1"> <span class="text-black">Large (1,392)</span>
                </label>
                            </div>

                            <div class="mb-4">
                                <h3 class="mb-3 h6 text-uppercase text-black d-block">Color</h3>
                                <a href="#" class="d-flex color-item align-items-center">
                                    <span class="bg-danger color d-inline-block rounded-circle mr-2"></span> <span class="text-black">Red (2,429)</span>
                                </a>
                                <a href="#" class="d-flex color-item align-items-center">
                                    <span class="bg-success color d-inline-block rounded-circle mr-2"></span> <span class="text-black">Green (2,298)</span>
                                </a>
                                <a href="#" class="d-flex color-item align-items-center">
                                    <span class="bg-info color d-inline-block rounded-circle mr-2"></span> <span class="text-black">Blue (1,075)</span>
                                </a>
                                <a href="#" class="d-flex color-item align-items-center">
                                    <span class="bg-primary color d-inline-block rounded-circle mr-2"></span> <span class="text-black">Purple (1,075)</span>
                                </a>
                            </div>

                        </div>
                    </div>
                </div>

            </div>
        </div>

        <div class="site-section">
            <div class="container">
                <div class="row">
                    <div class="title-section text-center col-12">
                        <h2 class="text-uppercase">The Collections</h2>
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
                            <p>If you would like to experience the best of online shopping for men, women and kids in India, you are at the right place. Online Shoppy is the ultimate destination for fashion and lifestyle, being host to a wide array of merchandise including clothing, footwear, personal care products and more.</p>
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
    </div>

    <script src="js/jquery-3.3.1.min.js"></script>
    <script src="js/jquery-ui.js"></script>
    <script src="js/popper.min.js"></script>
    <script src="js/bootstrap.min.js"></script>
    <script src="js/owl.carousel.min.js"></script>
    <script src="js/jquery.magnific-popup.min.js"></script>
    <script src="js/aos.js"></script>

    <script src="js/main.js"></script>

</body>

</html>
