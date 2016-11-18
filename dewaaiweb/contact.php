<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
	<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
	<title>De Waai - Homepagina</title>
	<link type="text/css" rel="stylesheet" href="http://www.dewaai.ga/css/main.css" />
	<link href="https://fonts.googleapis.com/css?family=Raleway:100,100i,200,200i,300,300i,400,400i,500,500i,600,600i,700,700i,800,800i,900,900i" rel="stylesheet">
</head>
<body>
<div id="Container">
	<?php include 'header.php';?>
    
    <div id="Content">
        <div class="bannertext">
        	<h1 class="bannertitle">Zeilplezier voor <strong style="color:white;">jong en oud</strong> bij De Waai</h1>
        </div>
        
        <img class="img-responsive img visual" src="/images/banner_bed.jpg" alt="banner homepagina" />
        
        <div id="Content_Text">
            <!-- CONTENT !-->
            <h2>Contact</h2>
            <p>
            Zijlschool de Waai is te vinden op dit adres:
            De waai 
            De waaiweg 100
            7895 BV Amsterdam
            De Waai is geopend op de volgende tijden</br></br>
            
            <table>
                	<Tr>
                    	<td>
                        Maandag
                        </td>
                        <td>
                        07:00 - 16:00
                        </td>
                    </Tr>
                    <Tr>
                    	<td>
                        Dinsdag
                        </td>
                        <td>
                        07:00 - 16:00
                        </td>
                    </Tr>                	
                    <Tr>
                    	<td>
                        Woensdag
                        </td>
                        <td>
                        07:00 - 16:00
                        </td>
                    </Tr>                	
                    <Tr>
                    	<td>
                        Donderdag
                        </td>
                        <td>
                        07:00 - 16:00
                        </td>
                    </Tr>                	
                    <Tr>
                    	<td>
                        Vrijdag
                        </td>
                        <td>
                        07:00 - 16:00
                        </td>
                    </Tr>                	
                    <Tr>
                    	<td>
                        Zaterdag
                        </td>
                        <td>
                        07:00 - 16:00
                        </td>
                    </Tr>
                    <Tr>
                    	<td>
                        Zondag
                        </td>
                        <td>
                        07:00 - 16:00
                        </td>
                    </Tr>
                </table>
            </p><br />

    	
       		<?php 
				include 'DBConnect.php';
				$page = "Instructors";
				DBConnectionSetup($page);
			?>
		
    </div>
    </div>
                
            
    <?php include 'footer.php';?>
</div>
</body>