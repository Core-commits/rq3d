/*Copyright 2020 dehoisted(blockplacer)

Redistribution and use in source and binary forms, with or without modification, are permitted provided that the following conditions are met:

1. Redistributions of source code must retain the above copyright notice, this list of conditions and the following disclaimer.

2. Redistributions in binary form must reproduce the above copyright notice, this list of conditions and the following disclaimer in the documentation and/or other materials provided with the distribution.

THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.*/




//OpenTk is dependency but code easy to port to sharpgl,glfw,software_renderers,unity,iedx

void model(string fileloc){
		  
  
   	 string[] lines = System.IO.File.ReadAllLines(fileloc);   //we load file
   	 string[] modelcontainer ={""};   //its empty beacuse without that it throws exception
   	 string contents = String.Concat(System.IO.File.ReadAllLines(fileloc)); //seperating arrays
         string line = "e";   //it should not empty for not throwing exceptions
         line = contents;    // setting contents into line to convert them to arrays and make it better 
         char[] remv = new char[] {' ', '\t'};
  
         modelcontainer = line.Split(remv, StringSplitOptions.RemoveEmptyEntries); //removing unneccesary stuff,converting array stuff...
         
         
         int contents2 = contents.Split(' ').Length; // find its length to not crash

             for (int i = 0; i <  contents2; i++) //for reading all array
                {
             	 if (modelcontainer[i].Contains("begin_tri")){
             		GL.Begin(BeginMode.Triangles);
             	}
             	if (modelcontainer[i].Contains("begin_triangle_strip")){
             		GL.Begin(BeginMode.TriangleStrip);
             	}
             	if (modelcontainer[i].Contains("begin_triangle_fan")){
             		GL.Begin(BeginMode.TriangleFan);
             	}
              	if (modelcontainer[i].Contains("begin_quads")){
             		GL.Begin(BeginMode.Quads);
             	}
             				
            	if (modelcontainer[i].Contains("begin_quad_strip")){
             		GL.Begin(BeginMode.QuadStrip);
             	}
      
             	if(modelcontainer[i].Contains("nx")){
             		GL.Normal3(Single.Parse(modelcontainer[i+1]),Single.Parse(modelcontainer[i+2]),Single.Parse(modelcontainer[i+3]));	
            	}
             	
             	if (modelcontainer[i].Contains("v")){
             		GL.Vertex3(Single.Parse(modelcontainer[i+1]),Single.Parse(modelcontainer[i+2]),Single.Parse(modelcontainer[i+3]));
         
   		}  
   
             
  		if (modelcontainer[i].Contains("end")){
             		GL.End();		
             	}
             }
}
