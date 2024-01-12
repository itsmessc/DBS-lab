# DBS-lab
Codes of DBS lab of ICT dept MIT Manipal



public static void ThreadProc()
{
     // Window Help = new Window();
     //Application.Run(new Window(Help);    

     Application.Run(new Form()); 
}

private void button1_Click(object sender, EventArgs e)
{

    System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(ThreadProc));

    t.Start();
}
