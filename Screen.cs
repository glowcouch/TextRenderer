using System;
using System.Diagnostics;
using System.Threading;

class Screen {
    float deltaTime = 0;
    //time at the last frame, used to calculate delta time
    float lastFrameTime = 0;

    //stopwatch for calculating delta time
    static Stopwatch time;
  
    public void StartMainLoop(){
        //start a stopwatch for calculating delta time
        time = new Stopwatch();
        time.Start();
        //make a mainloop thread
        Thread mainLoop = new Thread(new ThreadStart(Mainloop));
        //start the mainloop thread
        mainLoop.Start();
    }
  
    public void Mainloop(){
        while (true){
            //Calculate delta time
            deltaTime = time.ElapsedMilliseconds - lastFrameTime;
            //todo draw frame

            //set last frame time
            lastFrameTime = time.ElapsedMilliseconds;
        }
    }
}