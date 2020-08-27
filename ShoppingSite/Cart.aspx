<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cart.aspx.cs" Inherits="ShoppingSite.Cart" %>

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

                                <li><a href="shop.html">Shop</a></li>


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
                    <div class="col-md-12 mb-0"><a href="Products?UID=<%=Request.QueryString["UID"]%>&ID=1">Home</a> <span class="mx-2 mb-0">/</span> <strong class="text-black">Cart</strong></div>
                </div>
            </div>
        </div>

        <div class="site-section">
            <div class="container">
                <div class="row mb-5">
                    <form class="col-md-12" method="post">
                        <div class="site-blocks-table">
                            <table class="table table-bordered">
                                <thead>
                                    <tr>
                                        <th class="product-thumbnail">Image</th>
                                        <th class="product-name">Product</th>
                                        <th class="product-price">Price</th>
                                        <th class="product-quantity">Quantity</th>
                                        <th class="product-total">Total</th>
                                        <th class="product-remove">Remove</th>
                                    </tr>
                                </thead>
                                <tbody>
                                    <asp:Repeater runat="server" ID="rptProduct">
                                    <ItemTemplate>
                                    <tr>
                                      <input type="hidden" id="cardlistId" value="<%# Eval("cardlistId") %>">
                                       <input type="hidden" id="userId" value="<%=Request.QueryString["UID"]%>">

                                        <td class="product-thumbnail">
                                             <%# GetImage(Eval("imageurl")) %>
                                        </td>
                                        <td class="product-name">
                                            <h2 class="h5 text-black"><%# Eval("productName") %></h2>
                                        </td>
                                        <td>$<%# Eval("Price") %></td>
                                        <td>
                                            <div class="input-group mb-3" style="max-width: 120px;">
                                                <div class="input-group-prepend">
                                                    <button class="btn btn-outline-primary js-btn-minus" type="button">&minus;</button>
                                                </div>
                                                <input type="text" class="form-control text-center" value="<%# Eval("count") %>" placeholder="" aria-label="Example text with button addon" aria-describedby="button-addon1">
                                                <div class="input-group-append">
                                                    <button class="btn btn-outline-primary js-btn-plus" type="button">&plus;</button>
                                                </div>
                                            </div>

                                        </td>
                                        <td>$(<%# Getvalue(Eval("Price"),Eval("count")) %>) </td>
                                        <%--<td><a href="#" class="btn btn-primary height-auto btn-sm">X</a></td>--%>
                                        <td><input name="removeCard" id="removeCard" class="btn btn-primary height-auto btn-sm" type="button" value="Remove" ></td>

                                    </tr>
                                    </ItemTemplate>
                                    </asp:Repeater>
                                  
                                </tbody>
                            </table>
                        </div>
                    </form>
                </div>

                <div class="row">
                    <div class="col-md-6">
                        <div class="row mb-5">
                            
                            <div class="col-md-6">
                                <button class="btn btn-outline-primary btn-sm btn-block">Continue Shopping</button>
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

     <div class="modal fade" id="exampleModal" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
                <div class="modal-dialog modal-dialog-centered" role="document">
                    <div class="modal-content">
                        <div class="modal-header">
                            <h5 class="modal-title"  id="exampleModalLabel">Ready to Leave?</h5>
                            <button  class="close" type="button" data-dismiss="modal" aria-label="Close">
                                <span aria-hidden="true">×</span>
                            </button>
                        </div>
                        <div class="modal-body">Select "Logout" below if you are ready to end your current session.</div>
                        <div class="modal-footer">
                            <button class="btn btn-secondary" type="button" data-dismiss="modal">Cancel</button>
                            <button class="btn btn-secondary" type="button" data-dismiss="modal">Logout</button>

                        </div>
                    </div>
                </div>
            </div>

    </div>

   
    <script src="js/jquery-3.3.1.min.js"></script>
    <script src="js/jquery-ui.js"></script>
    <script src="js/popper.min.js"></script>
    <script src="js/bootstrap.min.js"></script>
    <script src="js/owl.carousel.min.js"></script>
    <script src="js/jquery.magnific-popup.min.js"></script>
    <script src="js/aos.js"></script>

    <script src="js/main.js"></script>

        <script>


            $('input[name = "removeCard"]').click(function (e) {


                var cardlistId = document.getElementById("cardlistId").value;
                var userId = document.getElementById("userId").value;

            $.ajax({
                type: "POST",
                url: 'Cart.aspx/DeleteCard',
                data: "{'cardlistId':'" + cardlistId + "'}",
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