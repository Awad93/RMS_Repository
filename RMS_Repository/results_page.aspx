<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="results_page.aspx.cs" Inherits="WebApplication1.results_page" %>

<!DOCTYPE html>
<html>
    <head>
	    <link href="Content/bootstrap.css" rel="stylesheet" type="text/css">
	    <link href="Content/style.css" rel="stylesheet" type="text/css">
	    <link href="Content/ionicons.css" rel="stylesheet" type="text/css">
	
	    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.12.2/jquery.min.js"></script>
	    <script src="http://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/js/bootstrap.min.js"></script>
	
	    <link href="Content/main.css" rel="stylesheet" type="text/css">
        <title>Results</title>
    </head>
    <body>
    <!-- Header -->
	    <header class="header">
		    <div class="container-fluid">
			    <div class="row" id="main-header">
			    <div class="col-md-6" >
				    <h1 class="col-md-offset-1">KFUPM Research Repository</h1>
			    </div>
			    </div>
		    </div>
	    </header>
    <!-- End: Header -->

    <!-- Sidebar -->
	    <div class="container-fluid">
		    <div class="row-fluid">	
			    <div class="col-md-3 col-lg-2">				    
			        <%--<asp:Literal runat="server">
				        <div  id="sidebar-list" class="panel">
					        <ul  id="listCollege" class="list-unstyled" runat="server">
						        <li class="text-center"><a href="main2.html">Home</a></li>   						
					        </ul>					
				        </div>
                    </asp:Literal>--%>
                    <asp:Repeater ID="repeaterColleges" runat="server" OnItemDataBound="repeaterColleges_ItemDataBound">
                        <HeaderTemplate>
                            <div  id="sidebar-list" class="panel">
					        <ul  id="listCollege" class="list-unstyled">
                                <li class="text-center"><a href="main2.html">Home</a></li>   
                        </HeaderTemplate>
                        <ItemTemplate>                            
                            <span class="panel">
                                <li data-toggle="collapse" href="#deptID<%#Eval("DepartmentID")%>" data-parent="#listCollege">
                                    <a><asp:Literal ID="ltrlCollege" runat="server"></asp:Literal></a>
                                    <%--<asp:HiddenField ID="hfvCollege" runat="server"/>--%>
                                </li>
                                <ul id="deptID<%#Eval("DepartmentID")%>" class="collapse list-unstyled">
                                    <asp:Repeater ID="repeaterDepartments" runat="server" OnItemDataBound="repeaterDepartments_ItemDataBound">                                        
                                        <ItemTemplate>                                            
                                            <li><a>
                                                <asp:Literal ID="ltrlDepartment" runat="server"></asp:Literal>
                                            </a></li>                                            
                                        </ItemTemplate>                                       
                                    </asp:Repeater>
                                </ul>
                            </span>                                                                                                                           
                        </ItemTemplate>
                        <FooterTemplate>
                            </ul>
                            </div>
                        </FooterTemplate>
                    </asp:Repeater>
			    </div>
    <!-- End: Sidebar -->

    <!-- Page content -->
	    <div class="col-lg-9" style="padding-left:0 !important;" id="content">
	
	    <!-- Breadcrumb -->
		    <div class="panel panel-default">
			    <ol	class="breadcrumb">
				    <li><a href="#">Home</a></li>
				    <li><a href="#">College of Science</a></li>
			    </ol>
		    </div>
	    <!-- End: Breadcrumb -->
	
	    <!-- <div class="container" id="content"> -->
		    <!-- <div class="panel" id="results_header">
			    <div class="row">
			    <div class="panel-body">
				    <div class="col-md-4" style=" color:white">
				    <p>Results for</p>
				    <h2>College of Science</h2>
				    </div>
				    <div class="col-md-3">
					    <div class="sm-st clearfix">
						    <div class="sm-st-icon st-green">
							    <i class="ion-android-note"></i>
						    </div>
						    <div class="sm-st-info">
							    <span>15</span>Journal publications
						    </div>
					    </div>
				    </div>
				    <div class="col-md-2">
					    <div class="sm-st clearfix">
						    <span class="sm-st-icon st-red">
							    <i class="ion-android-book"></i>
						    </span>
						    <div class="sm-st-info">
							    <span>3</span>Books
						    </div>
					    </div>
				    </div>
			    </div>
			    </div>
			    <form class="form-horizontal tasi-form">
				    <div class="form-group">
					    <label class="control-label col-sm-2 col-lg-2" for="dept-list" style="color:white;text-align:left">Departments:</label>
					    <div class="col-sm-9">
						    <select id="dept-list" class="form-control">
							    <option>All</option>
							    <option>Department of Mathematics</option>
						    </select>
					    </div>
				    </div>
			    </form>		
		    </div> -->
		    <!-- <div class="container well well-sm">			
			    <form class="form-horizontal tasi-form">
				    <div class="form-group">
					    <label class="control-label col-sm-1 col-lg-1" for="dept-list">Departments:</label>
					    <div class="col-sm-10">
						    <select id="dept-list" class="form-control">
							    <option>All</option>
							    <option>Department of Mathematics</option>
						    </select>
					    </div>
				    </div>
			    </form>			
		    </div> -->
		    <div class="panel">
			    <header class="panel-heading">
				    <ul class="nav nav-pills">
					    <li class="active"><a data-toggle="pill" href="#all">All</a></li>
					    <li><a data-toggle="pill" href="#year">By year</a></li>
					    <li><a data-toggle="pill" href="#faculty">By faculty</a></li>
					    <li><a data-toggle="pill" href="#area">By area</a></li>
				    </ul>
			    </header>
			    <div class="panel-body">
				    <div id="results-tab" class="tab-content pull-left">
					    <div id="all" class="tab-pane fade in active">
						    <h4>View all</h4>
						    <ul class="results-list collapse-arrow" style="padding-left:0">
							    <asp:Repeater ID="repeaterISIPublications" runat="server" OnItemDataBound="repeaterISIPublications_ItemDataBound">
                                   <HeaderTemplate>
                                        <li>
								            <a data-toggle="collapse" href="#journals">  ISI Journals <asp:Label class="label label-default" ID="lblTotalPublications" runat="server" ></asp:Label></a>
							            </li>
							            <ul class="results-list collapse collapse-arrow" id="journals">
                                   </HeaderTemplate>
                                   <ItemTemplate>
                                       <asp:Literal ID="ltrlyear" runat="server">
                                       </asp:Literal>
                                       <li class="list-bordered">
                                           <h4 style="color:blue"><asp:Literal ID="ltrlPaperTitle" runat="server">                                               
                                           </asp:Literal></h4>
                                           <h6 style="color:grey"><asp:Literal ID="ltrlAuthors" runat="server">
                                           </asp:Literal></h6>
                                           <h6><asp:Literal ID="PublicationYear" runat="server">
                                           </asp:Literal></h6>
                                       </li>                                       
                                   </ItemTemplate>
                                   <FooterTemplate>
                                       </ul>
                                   </FooterTemplate>
							   </asp:Repeater>
                                <asp:Repeater ID="repeaterNonISIPublications" runat="server" OnItemDataBound="repeaterNonISIPublications_ItemDataBound">
                                   <HeaderTemplate>
                                        <li>
								            <a data-toggle="collapse" href="#nonisijournals">  Non-ISI Journals <asp:Label class="label label-default" ID="lblTotalPublications" runat="server" ></asp:Label></a>
							            </li>
							            <ul class="results-list collapse collapse-arrow" id="nonisijournals">
                                   </HeaderTemplate>
                                   <ItemTemplate>
                                       <asp:Literal ID="ltrlyear" runat="server">
                                       </asp:Literal>
                                       <li class="list-bordered">
                                           <h4 style="color:blue"><asp:Literal ID="ltrlPaperTitle" runat="server">                                               
                                           </asp:Literal></h4>
                                           <h6 style="color:grey"><asp:Literal ID="ltrlAuthors" runat="server">
                                           </asp:Literal></h6>
                                           <h6><asp:Literal ID="PublicationYear" runat="server">
                                           </asp:Literal></h6>
                                       </li>                                       
                                   </ItemTemplate>
                                   <FooterTemplate>
                                       </ul>
                                   </FooterTemplate>
							      </asp:Repeater>
                                   <asp:Repeater ID="repeaterBooks" runat="server" OnItemDataBound="repeaterBooks_ItemDataBound">
                                   <HeaderTemplate>
                                       <li>
                                           <a data-toggle="collapse" href="#books">  Books <asp:Label class="label label-default" ID="lblTotalBooks" runat="server"></asp:Label></a> 
                                       </li>
                                       <ul class="collapse" id="books">
                                   </HeaderTemplate>
                                   <ItemTemplate>
                                       <asp:Literal ID="ltrlyear" runat="server">
                                       </asp:Literal>
                                       <li class="list-bordered">
                                           <h4 style="color:blue"><asp:Literal ID="ltrlBookTitle" runat="server">                                               
                                           </asp:Literal></h4>
                                           <h6 style="color:grey"><asp:Literal ID="ltrlAuthors" runat="server">
                                           </asp:Literal></h6>
                                           <h6><asp:Literal ID="ltrlPublicationYear" runat="server">
                                           </asp:Literal></h6>
                                       </li>
										    <%--<h4 style="color:blue"><%# Eval("BookTitle")%></h4>
										    <h6 style="color:grey"><%# Eval("Authors")%></h6>
										    <h6><%# Eval("PublicationYear")%></h6>--%>
									    
                                   </ItemTemplate>
                                   <FooterTemplate>
                                       </ul>
                                   </FooterTemplate>
							   </asp:Repeater>
                                 <%--<li>
								    <a data-toggle="collapse" href="#journals">  Journals <label class="label label-default">15</label></a>
							    </li>
							    <ul class="results-list" id="journals" class="collapse collapse-arrow">
								    <li>
									    <a data-toggle="collapse" href="#results"> 2016 <label class="label label-default">4</label></a>
								    </li>
								    <ul id="results" class="collapse">
									    <li class="list-bordered" data-toggle="collapse" href="#showmore1">
										    <h4 style="color:blue">Binary particle swarm optimization (BPSO) based state assignment for area minimization of sequential circuits</h4>
										    <h6 style="color:grey">Bhat, SS; Anand, D; Khanday, FA</h6>
										    <h6>Applied Soft Computing</h6>
									    </li>
									    <div id="showmore1" class="well collapse showmore pull-left">
										    <p><b>WOS: </b>000325759200028</p>
										    <p><b>Date: </b>2013</p>
										    <p><b>Journal: </b>Applied Soft Computing</p>
										    <p><b>Area: </b>Computer Science, Artificial Intelligence; Computer Science, Interdisciplinary Applications , Computer Science</p>
										    <p class="keywords"><b>Keyword(s): </b><label class="label label-default">State assignment (SA)</label><label class="label label-default">Area minimization</label><label class="label label-default">Non-determinism; Heuristics</label><label class="label label-default">PSO</label><label class="label label-default">Binary PSOa , GENETIC ALGORITHM</label><label class="label label-default">MACHINES</label><label class="label label-default">POWER</label></p>
										    <p><b>Abstract: </b>State assignment (SA) for finite state machines (FSMs) is one of the main optimization problems in the synthesis of sequential circuits. It determines the complexity of its combinational circuit and thus area, delay, testability and power dissipation of its implementation. Particle swarm optimization (PSO) is a non-deterministic heuristic that optimizes a problem by iteratively trying to improve a candidate solution with regard to a given measure of quality. PSO optimizes a problem by having a population of candidate solutions called particles, and moving them around in the search-space according to a simple mathematical formulae. In this paper, we propose an improved binary particle swarm optimization (BPSO) algorithm and demonstrate its effectiveness in solving the state assignment problem in sequential circuit synthesis targeting area optimization. It will be an evident that the proposed BPSO algorithm overcomes the drawbacks of the original BPSO algorithm. Experimental results demonstrate the effectiveness of the proposed BPSO algorithm in comparison to other BPSO variants reported in the literature and in comparison to Genetic Algorithm (GA), Simulated Evolution (SimE) and deterministic algorithms like Jedi and Nova. (c) 2013 Elsevier B.V. All rights reserved.</p>
									    </div>									
									    <li class="list-bordered">
										    <h4 style="color:blue">Binary particle swarm optimization (BPSO) based state assignment for area minimization of sequential circuits</h4>
										    <h6 style="color:grey">Bhat, SS; Anand, D; Khanday, FA</h6>
										    <h6>Applied Soft Computing</h6>
									    </li>
									    <li class="list-bordered">
										    <h4 style="color:blue">Binary particle swarm optimization (BPSO) based state assignment for area minimization of sequential circuits</h4>
										    <h6 style="color:grey">Bhat, SS; Anand, D; Khanday, FA</h6>
										    <h6>Applied Soft Computing</h6>
									    </li>
								    </ul>
								    <li><a data-toggle="collapse" href="#2014">  2014 <label class="label label-default">11</label></a></li>
							    </ul>
							    <li><a> Books <label class="label label-default">3</label></a></li>--%>
						    </ul>
					    </div>
					    <div id="year" class="tab-pane fade">
						    <h4>Year</h4>
					    </div>
					    <div id="faculty" class="tab-pane fade">
						    <h4>Faculty</h4>
                            <ul style="list-style:none">
                                <asp:Repeater ID="repeaterFaculty" runat="server" OnItemDataBound="repeaterFaculty_ItemDataBound">
                                       <ItemTemplate>
                                           <li>
								                <a class="h4"><asp:Literal ID="ltrlFaculty" runat="server" ></asp:Literal></a>
							                </li>                                              
                                          </ItemTemplate> 
							          </asp:Repeater>
                                </ul>
					    </div>
					    <div id="area" class="tab-pane fade">
						    <h4>Area</h4>
					    </div>
				    </div>
			    </div>
		    </div>
	    </div>
    </div>
    </div>
    <!-- End: page content -->
    <script>
    </script>

    </body>
</html>
