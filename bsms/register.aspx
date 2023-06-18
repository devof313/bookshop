<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="bsms.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
  <!-- Required meta tags -->
  <meta charset="utf-8"/>
  <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no"/>
  <title>BOOKSHOP</title>
  <!-- plugins:css -->
  <link rel="stylesheet" href="../../vendors/feather/feather.css"/>
  <link rel="stylesheet" href="../../vendors/ti-icons/css/themify-icons.css"/>
  <link rel="stylesheet" href="../../vendors/css/vendor.bundle.base.css"/>
  <!-- endinject -->
  <!-- Plugin css for this page -->
  <!-- End plugin css for this page -->
  <!-- inject:css -->
  <link rel="stylesheet" href="../../css/vertical-layout-light/style.css"/>
  <!-- endinject -->
  <link rel="shortcut icon" href="../../images/favicon.png" />
</head>

<body>
  <div class="container-scroller">
    <div class="container-fluid page-body-wrapper full-page-wrapper">
      <div class="content-wrapper d-flex align-items-center auth px-0">
        <div class="row w-100 mx-0">
          <div class="col-lg-4 mx-auto">
            <div class="auth-form-light text-left py-5 px-4 px-sm-5">

              <h2>New Employee</h2>
                <form runat="server">
           

                <div class="form-group">
<asp:TextBox ID="TextBox" runat="server" class="form-control form-control-lg" placeholder="Full Name"></asp:TextBox>

                </div>
                <div class="form-group">
<asp:TextBox ID="TextBox1" runat="server" class="form-control form-control-lg" placeholder="Username"></asp:TextBox>

                </div>
                <div class="form-group">
<asp:TextBox ID="TextBox2" runat="server" class="form-control form-control-lg" placeholder="Email"></asp:TextBox>
              
                </div>
                    <div class="form-group">
                        <asp:TextBox ID="TextBox5" runat="server" class="form-control form-control-lg" placeholder="Birthday" TextMode="Date"></asp:TextBox>

                    </div>
                <div class="form-group">
<asp:TextBox ID="TextBox4" runat="server" class="form-control form-control-lg" placeholder="Position"></asp:TextBox>
              
                </div>

                <div class="form-group">
<asp:TextBox ID="TextBox3" runat="server" class="form-control form-control-lg" placeholder="Password" TextMode="Password"></asp:TextBox>
              
                </div>

                <div class="mt-3">
                    <asp:Button ID="Button1" runat="server" Text="SIGN UP" class="btn btn-block btn-primary btn-lg font-weight-medium auth-form-btn" OnClick="Button1_Click" />
                
                </div>
                <div class="text-center mt-4 font-weight-light">
                 <a href="login.aspx" class="text-primary">Login</a>
                </div>
              </form>
                 
            </div>
          </div>
        </div>
      </div>
      <!-- content-wrapper ends -->
    </div>
    <!-- page-body-wrapper ends -->
  </div>
  <!-- container-scroller -->
  <!-- plugins:js -->
  <script src="../../vendors/js/vendor.bundle.base.js"></script>
  <!-- endinject -->
  <!-- Plugin js for this page -->
  <!-- End plugin js for this page -->
  <!-- inject:js -->
  <script src="../../js/off-canvas.js"></script>
  <script src="../../js/hoverable-collapse.js"></script>
  <script src="../../js/template.js"></script>
  <script src="../../js/settings.js"></script>
  <script src="../../js/todolist.js"></script>
  <!-- endinject -->
</body>
</html>
