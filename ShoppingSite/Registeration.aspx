<%@ Page Title="" Language="C#"  AutoEventWireup="true" CodeBehind="Registeration.aspx.cs" Inherits="ShoppingSite.Registeration" %>

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
    <div class="container-fluid">
        <div class="row">
            <div class="col-sm-6 login-section-wrapper">
                <div class="brand-wrapper">
                    <div class="logo">
                        <div class="site-logo">
                            <a href="Products?UID=<%=Request.QueryString["UID"]%>&ID=1" class="js-logo-clone">Online shoppy</a>
                        </div>
                    </div>
                </div>
                <div class="login-wrapper my-auto">
                    <h4 class="login-title">Registraion</h4>
                    <form action="#!">
                        <div class="form-group">
                            <label for="email">Name</label>
                            <input type="text" name="name" id="name" class="form-control" placeholder="enter your name">
                        </div>
                        <div class="form-group">
                            <label for="email">Email</label>
                            <input type="email" name="email" id="email" class="form-control" placeholder="enter your email">
                        </div>
                        <div class="form-group">
                            <label for="email">Phone Number</label>
                            <input type="text" name="phone" id="phone" class="form-control" placeholder="enter your phone">
                        </div>
                        <div class="form-group mb-4">
                            <label for="password">Password</label>
                            <input type="password" name="password" id="password" class="form-control" placeholder="enter your passsword">
                        </div>
                        <input name="register" id="register" class="btn btn-primary rounded-0 btn-block" type="button" value="Register" >
                    </form>
                </div>
            </div>
            <div class="col-sm-6 px-0 d-none d-sm-block">
                <img src="images/login.jpg" alt="login image" class="login-img">
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

       
        $('input[name = "register"]').click(function () {
            
            var name = document.getElementById("name").value;
            var phone = document.getElementById("phone").value;
            var email = document.getElementById("email").value;
            var password = document.getElementById("password").value;
   
                $.ajax({
                    type: "POST",
                    url: 'Registeration.aspx/CreateUser',
                    data: "{'name':'" + name + "','phone':'" + phone + "','email':'" + email + "','password':'" + password + "'}",
                    contentType: "application/json; charset=utf-8",
                    dataType: "json",
                    success: function (response) {
                        if (data.d == "Error") {
                            alert("Error while creating user");
                            window.location = "Registeration";

                        }
                        else {
                            window.location = "Login.aspx";
                        }

                    },
                    failure: function (response) {
                        alert("Error while creating user");
                    },
                
                });
            }
            );          
       

    </script>

</body>

</html>