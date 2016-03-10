//Maya ASCII 2016 scene
//Name: Plane002_Hite.ma
//Last modified: Thu, Mar 10, 2016 12:38:45 PM
//Codeset: UTF-8
requires maya "2016";
currentUnit -l centimeter -a degree -t film;
fileInfo "application" "maya";
fileInfo "product" "Maya 2016";
fileInfo "version" "2016";
fileInfo "cutIdentifier" "201502261600-953408";
fileInfo "osv" "Mac OS X 10.9.4";
fileInfo "license" "education";
createNode transform -n "pCube1";
	rename -uid "A129F6D3-1646-1A52-F4F8-AE8F3F85D62F";
createNode mesh -n "pCubeShape1" -p "pCube1";
	rename -uid "DBA2155B-734E-5046-B14F-5284D499D747";
	setAttr -k off ".v";
	setAttr ".vir" yes;
	setAttr ".vif" yes;
	setAttr ".pv" -type "double2" 0.5 0.5 ;
	setAttr ".uvst[0].uvsn" -type "string" "map1";
	setAttr -s 54 ".uvst[0].uvsp[0:53]" -type "float2" 0.375 0 0.625 0 0.375
		 0.25 0.625 0.25 0.375 0.5 0.625 0.5 0.375 0.75 0.625 0.75 0.375 1 0.625 1 0.875 0
		 0.875 0.25 0.125 0 0.125 0.25 0.5 0.125 0.5 0 0.5 1 0.625 0.125 0.5 0.25 0.375 0.125
		 0.5 0.375 0.625 0.375 0.75 0.25 0.5 0.5 0.25 0.25 0.375 0.375 0.5 0.625 0.625 0.625
		 0.875 0.125 0.5 0.75 0.125 0.125 0.375 0.625 0.5 0.875 0.625 0.875 0.75 0 0.5 1 0.25
		 0 0.375 0.875 0.75 0.125 0.75 0 0.875 0.125 0.75 0.25 0.25 0.125 0.25 0 0.25 0.25
		 0.125 0.125 0.125 0.125 0.125 0 0.25 0 0.25 0.125 0.75 0 0.875 0 0.875 0.125 0.75
		 0.125;
	setAttr ".cuvs" -type "string" "map1";
	setAttr ".dcc" -type "string" "Ambient+Diffuse";
	setAttr ".covm[0]"  0 1 1;
	setAttr ".cdvm[0]"  0 1 1;
	setAttr -s 34 ".vt[0:33]"  -0.35077754 -0.19198215 0.287321 0.35077754 -0.19198215 0.287321
		 -0.37443852 0.14797959 0.16264707 0.37443852 0.14797959 0.16264707 -0.16990095 0.34599108 -1.28536558
		 0.16990095 0.34599108 -1.28536558 -0.38810283 -0.012400091 -1.047686815 0.38810283 -0.012400091 -1.047686815
		 0 0 0.93723333 0 -0.19198215 0.287321 0.2639426 0 0.5 0 0.25628376 0.5263387 -0.2639426 0 0.5
		 0 0.34599108 -0.11734014 0.26221853 0.34599108 -0.11734014 0 0.8292563 -1.28536558
		 -0.26221853 0.34599108 -0.11734014 0 0.17958206 -1.16802549 0.5 0.19886664 -1.16802549
		 0 -0.012400091 -1.047686815 -0.5 0.19886664 -1.16802549 0 -0.19198215 -0.212679 0.38810283 -0.19198215 -0.212679
		 -0.38810283 -0.19198215 -0.212679 0.5 0 0 -0.5 0 0 -1.78188586 0 -1.91418934 -1.66998863 -0.042587951 -2.12686825
		 -1.067985535 -0.19198212 -1.23069298 -1.17988276 2.9802322e-08 -1.018013954 1.66998863 -0.042587951 -2.12686825
		 1.067985535 -0.19198212 -1.23069298 1.78188586 0 -1.91418934 1.17988276 2.9802322e-08 -1.018013954;
	setAttr -s 96 ".ed[0:95]"  0 9 0 2 11 0 4 15 0 6 19 0 0 12 0 1 10 0
		 2 16 0 3 14 0 4 20 0 5 18 0 6 23 0 7 22 0 9 1 0 10 3 0 11 3 0 12 2 0 9 8 0 10 8 0
		 11 8 0 12 8 0 14 5 0 15 5 0 16 4 0 11 13 0 14 13 0 15 13 0 16 13 0 18 7 0 19 7 0
		 20 6 0 15 17 0 18 17 0 19 17 0 20 17 0 22 1 0 23 0 0 19 21 0 22 21 0 9 21 0 23 21 0
		 22 24 0 18 24 0 14 24 0 10 24 0 23 25 0 12 25 0 16 25 0 20 25 0 20 26 0 6 27 0 26 27 0
		 23 28 0 27 28 0 25 29 0 28 29 0 26 29 0 7 30 0 22 31 0 30 31 0 18 32 0 32 30 0 24 33 0
		 32 33 0 31 33 0 9 12 1 2 13 1 4 17 1 6 21 1 1 24 1 28 26 1 10 9 1 11 10 1 12 11 1
		 3 13 1 5 13 1 4 13 1 5 17 1 7 17 1 6 17 1 7 21 1 1 21 1 0 21 1 32 31 1 14 18 1 3 24 1
		 0 25 1 2 25 1 20 16 1 27 20 1 28 6 1 29 23 1 20 29 1 7 31 1 18 30 1 33 18 1 22 33 1;
	setAttr -s 64 -ch 192 ".fc[0:63]" -type "polyFaces" 
		f 3 0 64 -5
		mu 0 3 0 15 19
		f 3 -65 16 -20
		mu 0 3 19 15 14
		f 3 -7 65 -27
		mu 0 3 25 2 20
		f 3 -66 1 23
		mu 0 3 20 2 18
		f 3 -9 66 -34
		mu 0 3 31 4 26
		f 3 -67 2 30
		mu 0 3 26 4 23
		f 3 -11 67 -40
		mu 0 3 37 6 32
		f 3 -68 3 36
		mu 0 3 32 6 29
		f 3 -6 68 -44
		mu 0 3 17 1 38
		f 3 -69 -35 40
		mu 0 3 38 1 39
		f 3 52 69 50
		mu 0 3 47 48 46
		f 3 -70 54 -56
		mu 0 3 46 48 49
		f 3 5 70 12
		mu 0 3 1 17 15
		f 3 -71 17 -17
		mu 0 3 15 17 14
		f 3 -15 71 13
		mu 0 3 3 18 17
		f 3 -72 18 -18
		mu 0 3 17 18 14
		f 3 -16 72 -2
		mu 0 3 2 19 18
		f 3 -73 19 -19
		mu 0 3 18 19 14
		f 3 14 73 -24
		mu 0 3 18 3 20
		f 3 -74 7 24
		mu 0 3 20 3 21
		f 3 20 74 -25
		mu 0 3 21 5 20
		f 3 -75 -22 25
		mu 0 3 20 5 23
		f 3 -3 75 -26
		mu 0 3 23 4 20
		f 3 -76 -23 26
		mu 0 3 20 4 25
		f 3 21 76 -31
		mu 0 3 23 5 26
		f 3 -77 9 31
		mu 0 3 26 5 27
		f 3 27 77 -32
		mu 0 3 27 7 26
		f 3 -78 -29 32
		mu 0 3 26 7 29
		f 3 -4 78 -33
		mu 0 3 29 6 26
		f 3 -79 -30 33
		mu 0 3 26 6 31
		f 3 28 79 -37
		mu 0 3 29 7 32
		f 3 -80 11 37
		mu 0 3 32 7 33
		f 3 34 80 -38
		mu 0 3 33 9 32
		f 3 -81 -13 38
		mu 0 3 32 9 35
		f 3 -1 81 -39
		mu 0 3 35 8 32
		f 3 -82 -36 39
		mu 0 3 32 8 37
		f 3 -61 82 -59
		mu 0 3 51 52 50
		f 3 -83 62 -64
		mu 0 3 50 52 53
		f 3 -21 83 -10
		mu 0 3 11 41 40
		f 3 -84 42 -42
		mu 0 3 40 41 38
		f 3 -8 84 -43
		mu 0 3 41 3 38
		f 3 -85 -14 43
		mu 0 3 38 3 17
		f 3 35 85 -45
		mu 0 3 43 0 42
		f 3 -86 4 45
		mu 0 3 42 0 19
		f 3 15 86 -46
		mu 0 3 19 2 42
		f 3 -87 6 46
		mu 0 3 42 2 44
		f 3 8 87 22
		mu 0 3 13 45 44
		f 3 -88 47 -47
		mu 0 3 44 45 42
		f 3 49 88 29
		mu 0 3 12 47 45
		f 3 -89 -51 -49
		mu 0 3 45 47 46
		f 3 51 89 10
		mu 0 3 43 48 12
		f 3 -90 -53 -50
		mu 0 3 12 48 47
		f 3 53 90 44
		mu 0 3 42 49 43
		f 3 -91 -55 -52
		mu 0 3 43 49 48
		f 3 -48 91 -54
		mu 0 3 42 45 49
		f 3 -92 48 55
		mu 0 3 49 45 46
		f 3 -12 92 -58
		mu 0 3 39 10 50
		f 3 -93 56 58
		mu 0 3 50 10 51
		f 3 -28 93 -57
		mu 0 3 10 40 51
		f 3 -94 59 60
		mu 0 3 51 40 52
		f 3 61 94 41
		mu 0 3 38 53 40
		f 3 -95 -63 -60
		mu 0 3 40 53 52
		f 3 -41 95 -62
		mu 0 3 38 39 53
		f 3 -96 57 63
		mu 0 3 53 39 50;
	setAttr ".cd" -type "dataPolyComponent" Index_Data Edge 0 ;
	setAttr ".cvd" -type "dataPolyComponent" Index_Data Vertex 0 ;
	setAttr ".pd[0]" -type "dataPolyComponent" Index_Data UV 0 ;
	setAttr ".hfd" -type "dataPolyComponent" Index_Data Face 0 ;
select -ne :time1;
	setAttr ".o" 1;
	setAttr ".unw" 1;
select -ne :hardwareRenderingGlobals;
	setAttr ".otfna" -type "stringArray" 22 "NURBS Curves" "NURBS Surfaces" "Polygons" "Subdiv Surface" "Particles" "Particle Instance" "Fluids" "Strokes" "Image Planes" "UI" "Lights" "Cameras" "Locators" "Joints" "IK Handles" "Deformers" "Motion Trails" "Components" "Hair Systems" "Follicles" "Misc. UI" "Ornaments"  ;
	setAttr ".otfva" -type "Int32Array" 22 0 1 1 1 1 1
		 1 1 1 0 0 0 0 0 0 0 0 0
		 0 0 0 0 ;
	setAttr ".fprt" yes;
select -ne :renderPartition;
	setAttr -s 2 ".st";
select -ne :renderGlobalsList1;
select -ne :defaultShaderList1;
	setAttr -s 4 ".s";
select -ne :postProcessList1;
	setAttr -s 2 ".p";
select -ne :defaultRenderingList1;
select -ne :initialShadingGroup;
	setAttr ".ro" yes;
select -ne :initialParticleSE;
	setAttr ".ro" yes;
select -ne :defaultResolution;
	setAttr ".pa" 1;
select -ne :hardwareRenderGlobals;
	setAttr ".ctrs" 256;
	setAttr ".btrs" 512;
connectAttr "pCubeShape1.iog" ":initialShadingGroup.dsm" -na;
// End of Plane002_Hite.ma
