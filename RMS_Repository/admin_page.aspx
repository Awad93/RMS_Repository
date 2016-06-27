﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="admin_page.aspx.cs" Inherits="RMS_Repository.admin_page" %>

<!DOCTYPE html>
<head>
	<link href="Content/bootstrap.css" rel="stylesheet" type="text/css">
	<link href="Content/style.css" rel="stylesheet" type="text/css">
	<link href="Content/ionicons.css" rel="stylesheet" type="text/css">
	<link href="Content/main.css" rel="stylesheet" type="text/css">
	
	<script src="https://ajax.googleapis.com/ajax/libs/jquery/1.12.2/jquery.min.js"></script>
	<script src="http://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/js/bootstrap.min.js"></script>
	
	<script src="http://xep.cloudformatter.com/doc/js/xepOnline.jqPlugin.008.js"></script> 
		
	<!-- Google Chart CDN + Script -->
	
	<!--Load the AJAX API-->
    <script type="text/javascript" src="https://www.gstatic.com/charts/loader.js"></script>
    
	<script type="text/javascript">
      // Load the Visualization API and the corechart package.
      google.charts.load('current', {'packages':['corechart']});

      // Set a callback to run when the Google Visualization API is loaded.
      google.charts.setOnLoadCallback(drawChart);

      // Callback that creates and populates a data table,
      // instantiates the pie chart, passes in the data and
      // draws it.
      function drawChart() {

         var data = google.visualization.arrayToDataTable([
          ['Year', 'Sales', 'Expenses'],
          ['2004',  1000,      400],
          ['2005',  1170,      460],
          ['2006',  660,       1120],
          ['2007',  1030,      540]
        ]);

        var options = {
          title: 'Company Performance',
          curveType: 'function',
          legend: { position: 'bottom' }
        };

        var chart = new google.visualization.LineChart(document.getElementById('mychart'));

        chart.draw(data, options);
      }
    </script>
	  
	  <!-- END: Google Chart -->
    </script>
	
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
				<div  id="sidebar-list" class="panel">
					<ul class="list-unstyled" id="accordion">
						<li class="text-center"><a>Home</a></li>
						<span class="panel">
						<li data-toggle="collapse" href="#dept-list1"  data-parent="#accordion"><a>College of Applied & Supporting Studies</a></li>
						<ul id="dept-list1" class="collapse list-unstyled">						
							<li><a>English Language Department</a></li>
							<li><a>General Studies</a></li>
							<li><a>Islamic and Arabic Studies</a></li>
							<li><a>Physical Education</a></li>
							<li><a>Prepratory Year</a></li>
						</ul>
						</span>
						<span class="panel">
						<li data-toggle="collapse" href="#dept-list2"  data-parent="#accordion"><a>College of Computer Science & Engineering</a></li>
						<ul id="dept-list2" class="collapse list-unstyled">	
							<li><a>Computer Engineering</a></li>
							<li><a>Information & Computer Science</a></li>
							<li><a>Systems Engineering</a></li>
						</ul>
						</span>
						<li><a>College of Engineering Sciences</a></li>
						<li><a>College of Environmental Design</a></li>
						<li><a>College of Industrial Management</a></li>
						<li><a>College of Petroleum Engineering & Geoscience</a></li>
						<li class="page"><a>College of Sciences</a></li>
						<li><a>Dammam Community College</a></li>
						<li><a>Harf Al-Batin Community College</a></li>
						<li><a>Research Institute</a></li>
						<li><a>Vice Rector Applied Research</a></li>
					</ul>					
				</div>
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
		<div class="panel">
			<header class="panel-heading">
				<ul class="nav nav-pills">
					<li class="active"><a data-toggle="pill" href="#all">All</a></li>
					<li><a data-toggle="pill" href="#statistics">Statistics</a></li>	
					<li><a data-toggle="pill" href="#year">By year</a></li>
					<li><a data-toggle="pill" href="#faculty">By faculty</a></li>
					<li><a data-toggle="pill" href="#area">By area</a></li>
				</ul>
			</header>
			<div class="panel-body">
				<div id="results-tab" class="tab-content pull-left">
					<div id="all" class="tab-pane fade in active">
						<h4>View all</h4>
						<ul class="results-list" style="padding-left:0">
							<li><a data-toggle="collapse" href="#journals">  Journals <label class="label label-default">15</label></a></li>
								<ul class="results-list" id="journals" class="collapse">
									<li><a data-toggle="collapse" href="#results">  2016 <label class="label label-default">4</label></a></li>
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
							<li><a>  Books <label class="label label-default">3</label></a></li>
						</ul>
					</div>
					<div id="statistics" class="tab-pane fade">
						<h4>Yearly Statistics</h4>
						<form class="form-horizontal tasi-form">
							<div class="form-group">
								<label class="col-sm-2 control-label col-lg-2" style="text-align:left;" for="show_chart">Show chart for: </label>
								<div class="col-sm-4">
                                    <form runat="server">
									<asp:DropDownList id="show_chart" class="form-control" runat="server" AutoPostBack="true">
										<asp:ListItem Value="points">Publication Points</asp:ListItem>
										<asp:ListItem Value="isi">ISI</asp:ListItem>
										<asp:ListItem Value="nonisi">Non-ISI</asp:ListItem>
										<asp:ListItem Value="conferences">Conferences</asp:ListItem>
										<asp:ListItem Value="patents">Patents</asp:ListItem>
										<asp:ListItem Value="books">Books</asp:ListItem>
										<asp:ListItem Value="projects">Projects</asp:ListItem>
										<asp:ListItem Value="sh_courses">Short courses funding</asp:ListItem>
										<asp:ListItem Value="grad_students">Graduate students</asp:ListItem>
									</asp:DropDownList>
                                    </form>
								</div>
								<div class="col-md-offset-2 col-md-2">
									<button id="generate-report" type="button" class="btn btn-info" data-toggle="modal" data-target="#report-modal">Create report</button>
								</div>
							</div>
						</form>
						<div id="report-modal" class="modal fade" role="dialog">
							<div class="modal-dialog modal-lg">
								<div class="modal-content">
									<div class="modal-header">
										<button type="button" class="close" data-dismiss="modal">&times;</button>
										<h4 class="modal-title">Statistics: All Time</h4>
									</div>
									<div class="modal-body">
										<table class="table table-striped table-bordered">
											<thead>
												<tr>
													<th rowspan="2">Year</th>
													<th rowspan="2">ISI</th>
													<th rowspan="2">Non-ISI</th>
													<th rowspan="2">Publication Points (PP)</th>
													<th rowspan="2">Conferences</th>
													<th rowspan="2">Patents</th>
													<th rowspan="2">Books</th>
													<th colspan="2">Projects</th>
													<th colspan="2">Funds</th>
													<th rowspan="2">Short courses funding</th>
													<th rowspan="2">Graduate students</th>
												</tr>
												<tr>
													<th>Internal</th>
													<th>NSTP</th>
													<th>Internal</th>
													<th>NSTP</th>
												</tr>
											</thead>
										</table>
									</div>									
								</div>
							</div>
						</div>
						<h5>Publication points</h5>
						<div>
						<!-- Chart -->
							<div style="overflow:hidden">
								<div id="mychart" style="height:300px;"></div>
							</div>
						<!-- End: Chart -->
						</div>
						<div id="summary">
							<span class="row">
								<h2 class="col-md-4">Summary<small>  of the last 8 years</small></h2>
								<div class="col-md-2">
									<button type="button" class="btn btn-success" style="margin-top:20px" data-toggle="modal" data-target="#statistics-modal">Show more</button>
								</div>
							</span>
							<div id="statistics-modal" class="modal fade" role="dialog">
								<div class="modal-dialog modal-lg">
									<div class="modal-content">
										<div class="modal-header">
											<button type="button" class="close" data-dismiss="modal">&times;</button>
											<h4 class="modal-title">Statistics: All Time</h4>
										</div>
										<div class="modal-body">
											<table class="table table-striped table-bordered">
												<thead>
													<tr>
														<th rowspan="2">Year</th>
														<th rowspan="2">ISI</th>
														<th rowspan="2">Non-ISI</th>
														<th rowspan="2">Publication Points (PP)</th>
														<th rowspan="2">Conferences</th>
														<th rowspan="2">Patents</th>
														<th rowspan="2">Books</th>
														<th colspan="2">Projects</th>
														<th colspan="2">Funds</th>
														<th rowspan="2">Short courses funding</th>
														<th rowspan="2">Graduate students</th>
													</tr>
													<tr>
														<th>Internal</th>
														<th>NSTP</th>
														<th>Internal</th>
														<th>NSTP</th>
													</tr>
												</thead>
											</table>
										</div>									
									</div>
								</div>
							</div>
							<div style="border-top:1px solid #eeeeee;">
								<div class="col-md-6" style="border-right:1px solid #eeeeee;">
									<h4>Publications:</h4>
									<h5>6 total publication in 2016</h5>
									<table class="table table-bordered">
										<thead>
											<tr>
												<th>Year</th>
												<th>ISI</th>
												<th>Non-ISI</th>
												<th>Publication Points</th>
												<th>Books</th>
											</tr>
										</thead>
										<tbody>
											<tr>
												<td>2016</td>
												<td>6</td>
												<td>0</td>
												<td>3.5</td>
												<td>0</td>
											</tr>
											<tr>
												<td>2015</td>
												<td>25</td>
												<td>0</td>
												<td>15.25</td>
												<td>2</td>
											</tr>
											<tr>
												<td>2014</td>
												<td>6</td>
												<td>0</td>
												<td>3.5</td>
												<td>0</td>
											</tr>
											<tr>
												<td>2013</td>
												<td>6</td>
												<td>0</td>
												<td>3.5</td>
												<td>0</td>
											</tr>
											<tr>
												<td>2012</td>
												<td>6</td>
												<td>0</td>
												<td>3.5</td>
												<td>0</td>
											</tr>
											<tr>
												<td>2011</td>
												<td>6</td>
												<td>0</td>
												<td>3.5</td>
												<td>0</td>
											</tr>
											<tr>
												<td>2010</td>
												<td>6</td>
												<td>0</td>
												<td>3.5</td>
												<td>0</td>
											</tr>
											<tr>
												<td>2009</td>
												<td>6</td>
												<td>0</td>
												<td>3.5</td>
												<td>0</td>
											</tr>
											<tr>
												<td>2008</td>
												<td>6</td>
												<td>0</td>
												<td>3.5</td>
												<td>0</td>
											</tr>											
										</tbody>
									</table>
								</div>
								<div class="col-md-6">
									<h4>Conferences & Patents:</h4>
									<h5>3 conferences & 5 patents in 2016</h5>
									<table class="table table-bordered">
										<thead>
											<tr>
												<th>Year</th>
												<th>Conferences</th>
												<th>Patents</th>
											</tr>
										</thead>
										<tbody>
											<tr>
												<td>2016</td>
												<td>0</td>
												<td>0</td>
											</tr>
											<tr>
												<td>2015</td>
												<td>0</td>
												<td>0</td>
											</tr>
											<tr>
												<td>2014</td>
												<td>0</td>
												<td>0</td>
											</tr>
											<tr>
												<td>2013</td>
												<td>0</td>
												<td>0</td>
											</tr>
											<tr>
												<td>2012</td>
												<td>0</td>
												<td>0</td>
											</tr>
											<tr>
												<td>2011</td>
												<td>0</td>
												<td>0</td>
											</tr>
											<tr>
												<td>2010</td>
												<td>0</td>
												<td>0</td>
											</tr>
											<tr>
												<td>2009</td>
												<td>0</td>
												<td>0</td>
											</tr>
											<tr>
												<td>2008</td>
												<td>0</td>
												<td>0</td>
											</tr>
										</tbody>
									</table>
								</div>
							</div>							
							<div class="col-md-12" style="border-top:1px solid #eeeeee;">
								<h4>Projects:</h4>
								<h5>3 total projects funded in 2016</h5>
								<table class="table table-bordered">
									<thead>
										<tr>
											<th rowspan="2">Year</th>
											<th colspan="2">Internal</th>
											<th colspan="2">NSTP</th>
										</tr>
										<tr>
											<th>Projects</th>
											<th>Funds</th>
											<th>Projects</th>
											<th>Funds</th>
										</tr>
									</thead>
									<tbody>
										<tr>
											<td>2016</td>
											<td>2</td>
											<td>45,600 <small>SAR</small></td>
											<td>0</td>											
											<td>0</td>
										</tr>
										<tr>
											<td>2015</td>
											<td>2</td>
											<td>45,600 <small>SAR</small></td>
											<td>0</td>											
											<td>0</td>
										</tr>
										<tr>
											<td>2014</td>
											<td>2</td>
											<td>45,600 <small>SAR</small></td>
											<td>0</td>											
											<td>0</td>
										</tr>
										<tr>
											<td>2013</td>
											<td>2</td>
											<td>45,600 <small>SAR</small></td>
											<td>0</td>											
											<td>0</td>
										</tr>
										<tr>
											<td>2012</td>
											<td>2</td>
											<td>45,600 <small>SAR</small></td>
											<td>0</td>											
											<td>0</td>
										</tr>
										<tr>
											<td>2011</td>
											<td>2</td>
											<td>45,600 <small>SAR</small></td>
											<td>0</td>											
											<td>0</td>
										</tr>
										<tr>
											<td>2010</td>
											<td>2</td>
											<td>45,600 <small>SAR</small></td>
											<td>0</td>											
											<td>0</td>
										</tr>
										<tr>
											<td>2009</td>
											<td>2</td>
											<td>45,600 <small>SAR</small></td>
											<td>0</td>											
											<td>0</td>
										</tr>
										<tr>
											<td>2008</td>
											<td>2</td>
											<td>45,600 <small>SAR</small></td>
											<td>0</td>											
											<td>0</td>
										</tr>
									</tbody>
								</table>
							</div>
							<div class="col-md-12" style="border-top:1px solid #eeeeee;">
								<h4>Short courses & Graduate students:</h4>
								<h5>0 short courses funds & 0 graduate students in 2016</h5>
								<table class="table table-bordered">
									<thead>
										<tr>
											<th>Year</th>
											<th>Short courses funding</th>
											<th>Graduate students</th>
										</tr>
									</thead>
									<tbody>
										<tr>
											<td>2016</td>
											<td>0</td>
											<td>0</td>
										</tr>
										<tr>
											<td>2015</td>
											<td>0</td>
											<td>0</td>
										</tr>
										<tr>
											<td>2014</td>
											<td>0</td>
											<td>0</td>
										</tr>
										<tr>
											<td>2013</td>
											<td>0</td>
											<td>0</td>
										</tr>
										<tr>
											<td>2012</td>
											<td>0</td>
											<td>0</td>
										</tr>
										<tr>
											<td>2011</td>
											<td>0</td>
											<td>0</td>
										</tr>
										<tr>
											<td>2010</td>
											<td>0</td>
											<td>0</td>
										</tr>
										<tr>
											<td>2009</td>
											<td>0</td>
											<td>0</td>
										</tr>
										<tr>
											<td>2008</td>
											<td>0</td>
											<td>0</td>
										</tr>
									</tbody>
								</table>
							</div>		
							<table style="visibility:hidden" class="table table-striped table-bordered">
								<thead>
									<tr>
										<th rowspan="2">Year</th>
										<th rowspan="2">ISI</th>
										<th rowspan="2">Non-ISI</th>
										<th rowspan="2">Publication Points (PP)</th>
										<th rowspan="2">Conferences</th>
										<th rowspan="2">Patents</th>
										<th rowspan="2">Books</th>
										<th colspan="2">Projects</th>
										<th colspan="2">Funds</th>
										<th rowspan="2">Short courses funding</th>
										<th rowspan="2">Graduate students</th>
									</tr>
									<tr>
										<th>Internal</th>
										<th>NSTP</th>
										<th>Internal</th>
										<th>NSTP</th>
									</tr>
								</thead>
							</table>
						</div>
					</div>
					<div id="year" class="tab-pane fade">
						<h4>Year</h4>
					</div>
					<div id="faculty" class="tab-pane fade">
						<h4>Faculty</h4>
					</div>
					<div id="area" class="tab-pane fade">
						<h4>Area</h4>
					</div>
				</div>
			</div>
		</div>
	</div>
<!-- End: page content -->
<!-- <script>
	var pp_graph = Morris.Line({
	  // ID of the element in which to draw the chart.
		element: 'mychart',
	  // Chart data records -- each entry in this array corresponds to a point on
	  // the chart.
	  data: [
		{ year: '2008', value: 3.5 },
		{ year: '2009', value: 18 },
		{ year: '2010', value: 15.25 },
		{ year: '2011', value: 9 },
		{ year: '2012', value: 14 },
		{ year: '2013', value: 6.25 },
		{ year: '2014', value: 6.5 },
		{ year: '2015', value: 5 },
		{ year: '2016', value: 2.5 },
	  ],
	  // The name of the data record attribute that contains x-values.
	  xkey: 'year',
	  // A list of names of data record attributes that contain y-values.
	  ykeys: ['value'],
	  // Labels for the ykeys -- will be displayed when you hover over the
	  // chart.
	  labels: ['Publication points'],
	  lineColors:['#20A318'],
	  pointFillColors:['#10520C']
	});
	
	$('ul.nav a').on('shown.bs.tab', function (e) {
		pp_graph.redraw();
	});
		
	$('#generate-report').click(function () {
	printMe();
	});
	
	function printMe() {
	  xepOnline.Formatter.Format('mychart',{render:'download', srctype:'svg'});	 
	 };

</script> -->
<script>
	$('ul.nav a').on('shown.bs.tab', function (e) {
		drawChart();
});
</script>
</body>