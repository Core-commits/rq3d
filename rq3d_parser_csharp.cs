/*Copyright 2020 dehoisted(blockplacer)

Redistribution and use in source and binary forms, with or without modification, are permitted provided that the following conditions are met:

1. Redistributions of source code must retain the above copyright notice, this list of conditions and the following disclaimer.

2. Redistributions in binary form must reproduce the above copyright notice, this list of conditions and the following disclaimer in the documentation and/or other materials provided with the distribution.

THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.*/




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
