//OpenTk is dependency but code easy to port to sharpgl,glfw,software_renderers,unity,iedx

void model(string fileloc){
		  
  
   	 string[] lines = System.IO.File.ReadAllLines(fileloc); //we load file
   	  string[] ohherewego ={"" };
   	  string contenta = String.Concat(System.IO.File.ReadAllLines(fileloc)); //seperating arrays
   	
           
            string line = "e";
            line = contenta;
             char[] remv = new char[] {' ', '\t'};
  
           ohherewego = line.Split(remv, StringSplitOptions.RemoveEmptyEntries); //removing unneccesary stuff
         
           
        int contents2 = contenta.Split(' ').Length/*;*/;

             for (int i = 0; i <  contents2;  /*18*/ /*;*/ i++)
                {
             	 if (ohherewego[i].Contains("begin_tri")){
             		GL.Begin(BeginMode.Triangles);
             	}
             		 if (ohherewego[i].Contains("begin_triangle_strip")){
             		GL.Begin(BeginMode.TriangleStrip);
             	}
             		 if (ohherewego[i].Contains("begin_triangle_fan")){
             		GL.Begin(BeginMode.TriangleFan);
             	}
              	 if (ohherewego[i].Contains("begin_quads")){
             		GL.Begin(BeginMode.Quads);
             	}
             				
            	 if (ohherewego[i].Contains("begin_quad_strip")){
             		GL.Begin(BeginMode.QuadStrip);
             	}
      
             		if(ohherewego[i].Contains("nx")){
             		
             		GL.Normal3(Single.Parse(ohherewego[i+1]),Single.Parse(ohherewego[i+2]),Single.Parse(ohherewego[i+3]));
            		//GL.Normal3(Single.Parse(ohherewego[i+1]),Single.Parse(ohherewego[i+2]),Single.Parse(ohherewego[i+3]));
            	}
             	
             	 if (ohherewego[i].Contains("v")){
             		
             		
             		
             		GL.Vertex3(Single.Parse(ohherewego[i+1]),Single.Parse(ohherewego[i+2]),Single.Parse(ohherewego[i+3]));
             		//GL.Vertex3(Single.Parse(ohherewego[i+4]),Single.Parse(ohherewego[i+5]),Single.Parse(ohherewego[i+6]));
             	//	GL.Vertex3(Single.Parse(ohherewego[i+7]),Single.Parse(ohherewego[i+8]),Single.Parse(ohherewego[i+9]));                                                                                                                                  
             		
             		//Application.Exit();
         
   }  
   
             
              if (ohherewego[i].Contains("box")){
             		
             		//Add your own Block Shaped Model Code
             		//Block(Single.Parse(ohherewego[i+1]),Single.Parse(ohherewego[i+2]),Single.Parse(ohherewego[i+3]),Single.Parse(ohherewego[i+4]),Single.Parse(ohherewego[i+5]),Single.Parse(ohherewego[i+6]));
             }
    if (ohherewego[i].Contains("end")){
             GL.End();		
             }
         	}}
