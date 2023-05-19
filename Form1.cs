using System.Diagnostics.Metrics;
using System.Globalization;
using System.Windows.Forms.VisualStyles;

namespace Operating_Systems_Project
{

    public partial class Form1 : System.Windows.Forms.Form
    {
        int processCounter = 0;
        Process[] processes = new Process[5];
        public Form1()
        {
            InitializeComponent();

        }

        private void resetInput()
        {
            ArrivalTime.Text = "";
            BurstTime.Text = "";
        }
        private void UpdateQueue()
        {
            if (processCounter == 0)
            {
                currentPocesses.Text = string.Format("{0,-35}{1,-35}{2,-35}\n", "Process No.", "Arrival Time", "Burst Time");
                currentPocesses.Text += "----------------------------------------------------------------------\n";
            }


            else
            {
                currentPocesses.Text += string.Format("{0,-45}{1,-45}{2,-45}\n"
                    , "P" + processes[processCounter - 1].pid, processes[processCounter - 1].arrivalTime
                    , processes[processCounter - 1].burstTime);
                currentPocesses.Text += "----------------------------------------------------------------------\n";

            }
            ProcessName.Text = "P" + (processCounter + 1);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateQueue();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (processCounter == 5)
            {
                MessageBox.Show("Cannot Import more than 5 Process at a time.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                int arrival = Convert.ToInt16(ArrivalTime.Text.ToString());
                int burst = Convert.ToInt16(BurstTime.Text.ToString());
                processCounter++;


                processes[processCounter - 1] = new Process { pid = processCounter, arrivalTime = arrival, burstTime = burst };
                UpdateQueue();
            }
            catch (Exception)
            {
                MessageBox.Show("Enter A Valid Arrival Time & Burst time (Integers ONLY)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            resetInput();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            processCounter = 0;
            UpdateQueue();
            resetInput();
        }


        private void startButton_Click(object sender, EventArgs e)
        {
            if (processCounter == 0)
            {
                MessageBox.Show("Queue is Empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Process[] p = processes.Take(processCounter).ToArray();
            List<Process> ls = new List<Process>();
            int ind = 0;
            int idleTime = 0;
            if (AlgorithmsMenu.SelectedIndex == 0)
            {
                Array.Sort(p, (x, y) => x.arrivalTime.CompareTo(y.arrivalTime));
                ls = p.ToList();
                if (p[0].arrivalTime != 0)
                {
                    idleTime = p[0].arrivalTime;
                    Process idle = new Process();
                    idle.arrivalTime = 0;
                    idle.CompletionTime = idleTime;
                    idle.pid = -1;
                    ls.Insert(0, idle);
                    ind++;
                }

                p[0].waitingTime = 0;
                int completeTime = p[0].burstTime + p[0].arrivalTime;
                p[0].CompletionTime = completeTime;
                p[0].turnaroundTime = completeTime - p[0].arrivalTime;
                for (int i = 1; i < p.Length; i++)
                {
                    if (p[i].arrivalTime > completeTime)
                    {
                        int delay = p[i].arrivalTime - completeTime;
                        Process idle = new Process();
                        idle.arrivalTime = p[i - 1].CompletionTime;
                        idle.CompletionTime = delay;
                        idle.pid = -1;
                        ls.Insert(i + ind, idle);
                        ind++;
                        completeTime += delay + p[i].burstTime;
                        p[i].CompletionTime = completeTime;
                        p[i].turnaroundTime = completeTime - p[i].arrivalTime;
                        p[i].waitingTime = p[i].turnaroundTime - p[i].burstTime;

                    }

                    else
                    {

                        completeTime += p[i].burstTime;
                        p[i].CompletionTime = completeTime;
                        p[i].turnaroundTime = completeTime - p[i].arrivalTime;
                        p[i].waitingTime = p[i].turnaroundTime - p[i].burstTime;

                    }
                }
                double totalWaitingTime = 0;
                double totalTurnaroundTime = 0;
                for (int i = 0; i < p.Length; i++)
                {
                    totalWaitingTime += p[i].waitingTime;
                    totalTurnaroundTime += p[i].turnaroundTime;
                }

                double averageWaitingTime = totalWaitingTime / p.Length;
                double averageTurnaroundTime = totalTurnaroundTime / p.Length;

                AvgWaiting.Text = averageWaitingTime + "";
                TurnAround.Text = averageTurnaroundTime + "";

            }

            else if (AlgorithmsMenu.SelectedIndex == 1)
            {
                List<Process> list = new List<Process>();
                int[] arrival_time = new int[10];
                int[] burst_time = new int[10];
                int[] temp = new int[10];
                int i, smallest, count = 0, time;
                double wait_time = 0, turnaround_time = 0, end;
                float average_waiting_time, average_turnaround_time;

                
                for (i = 0; i < p.Length; i++)
                {
                    arrival_time[i] = p[i].arrivalTime;
                    burst_time[i] = p[i].burstTime;
                    temp[i] = burst_time[i];
                }
                burst_time[9] = 9999;
                for (time = 0; count != p.Length; time++)
                {
                    smallest = 9;
                    for (i = 0; i < p.Length; i++)
                    {
                        if (arrival_time[i] <= time && burst_time[i] < burst_time[smallest] && burst_time[i] > 0)
                        {
                            smallest = i;
                        }
                    }
                    Process pr = new Process();
                    pr.pid = smallest+1;
                    pr.arrivalTime = arrival_time[smallest];
                    pr.CompletionTime = 1;
                    pr.burstTime = 1;
                    list.Add(pr);

                    burst_time[smallest]--;
                    if (burst_time[smallest] == 0)
                    {
                        count++;
                        end = time + 1;
                        wait_time = wait_time + end - arrival_time[smallest] - temp[smallest];
                        turnaround_time = turnaround_time + end - arrival_time[smallest];
                    }
                }
                average_waiting_time = (float)wait_time / p.Length;
                average_turnaround_time = (float)turnaround_time / p.Length;

                AvgWaiting.Text = average_waiting_time + "";
                TurnAround.Text = average_turnaround_time + "";

                int k = 0;
                while (k < list.Count-1)
                {
                    if (list[k].pid == list[k + 1].pid)
                    {
                        list[k].burstTime++;
                        list[k].CompletionTime++;
                        list.RemoveAt(k+1);
                    }
                    else
                    {
                        k++;
                    }
                }
                ls = list;

            }

            else if (AlgorithmsMenu.SelectedIndex == 2)
            {
                
                int completeTime = 0;

                Array.Sort(p, (x, y) => x.arrivalTime.CompareTo(y.arrivalTime));
                for (int i = 0; i < p.Length; i++)
                {
                    int minIndex = i;
                    for (int j = i + 1; j < p.Length; j++)
                    {
                        if (p[j].burstTime < p[minIndex].burstTime && (p[j].arrivalTime <= completeTime || p[j].arrivalTime <= p[minIndex].arrivalTime))
                        {
                            minIndex = j;
                        }
                    }

                    Process temp = p[i];
                    p[i] = p[minIndex];
                    p[minIndex] = temp;

                    if (i == 0)
                    {
                        p[0].waitingTime = 0;
                        completeTime = p[0].burstTime + p[0].arrivalTime;
                        p[0].CompletionTime = completeTime;
                        p[0].turnaroundTime = completeTime - p[0].arrivalTime;
                    }

                    else
                    {
                        if (p[i].arrivalTime > completeTime)
                        {
                            completeTime += p[i].burstTime + (p[i].arrivalTime - completeTime);
                            p[i].turnaroundTime = completeTime - p[i].arrivalTime;
                            p[i].waitingTime = p[i].turnaroundTime - p[i].burstTime;
                            p[i].CompletionTime = completeTime;

                        }

                        else
                        {

                            completeTime += p[i].burstTime;
                            p[i].turnaroundTime = completeTime - p[i].arrivalTime;
                            p[i].waitingTime = p[i].turnaroundTime - p[i].burstTime;
                            p[i].CompletionTime = completeTime;

                        }
                    }

                }

                double totalWaitingTime = 0;
                double totalTurnaroundTime = 0;
                for (int i = 0; i < p.Length; i++)
                {
                    totalWaitingTime += p[i].waitingTime;
                    totalTurnaroundTime += p[i].turnaroundTime;
                }

                double averageWaitingTime = totalWaitingTime / p.Length;
                double averageTurnaroundTime = totalTurnaroundTime / p.Length;

                AvgWaiting.Text = averageWaitingTime + "";
                TurnAround.Text = averageTurnaroundTime + "";

                ls = p.ToList();
                int totalTime = 0;
                for (int i = 0; i < p.Length; i++)
                {
                    if (i == 0)
                    {
                        if (p[i].arrivalTime > 0)
                        {
                            idleTime = p[i].arrivalTime;
                            Process pr = new Process();
                            pr.CompletionTime = idleTime;
                            pr.pid = -1;
                            ls.Insert(0, pr);
                            ind++;
                            totalTime += idleTime + p[i].burstTime;
                        }

                        else
                        {
                            totalTime += p[i].burstTime;
                        }
                    }

                    else
                    {
                        if (p[i].arrivalTime > totalTime)
                        {
                            int delay = p[i].arrivalTime - p[i - 1].CompletionTime;
                            Process idle = new Process();
                            idle.arrivalTime = p[i - 1].CompletionTime;
                            idle.burstTime = delay;
                            idle.CompletionTime = idle.burstTime;
                            idle.pid = -1;
                            ls.Insert(i + ind, idle);
                            ind++;
                            totalTime += delay + p[i].burstTime;

                        }
                        else
                        {
                            totalTime += p[i].burstTime;
                        }
                    }
                }
            }

            else if (AlgorithmsMenu.SelectedIndex == 3)
            {
                int tq = 0;
                try
                {
                    tq = Convert.ToInt16(QValue.Text);
                    if (tq == 0)
                        throw new IOException();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Please Enter a valid Quantum Value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                List<Process> processTimeList = new List<Process>();
                int totalTurn = 0, totalWaiting = 0, index;
                float avgTurn, avgWaiting;
                int[] burstArr = new int[50];

                for (int i = 0; i < p.Length; i++)
                {
                    burstArr[i] = p[i].burstTime;
                }

                Queue<int> q = new Queue<int>();
                int currentTime = 0;
                q.Enqueue(0);
                int completed = 0;
                int[] mark = new int[100];

                while (completed != p.Length)
                {
                    index = q.Dequeue();

                    
                    if (burstArr[index] - tq > 0)
                    {
                        burstArr[index] -= tq;
                        currentTime += tq;
                        processTimeList.Add(new Process { pid = p[index].pid, arrivalTime = p[index].arrivalTime, burstTime = tq }); ;

                    }
                    else
                    {
                        currentTime += burstArr[index];
                        p[index].CompletionTime = currentTime;
                        p[index].turnTime = p[index].CompletionTime - p[index].arrivalTime;
                        p[index].waitingTime = p[index].turnTime - p[index].burstTime;
                        totalWaiting += p[index].waitingTime;
                        totalTurn += p[index].turnTime;
                        completed++;
                        processTimeList.Add(new Process { pid = p[index].pid, arrivalTime = p[index].arrivalTime, burstTime = burstArr[index] }); ;
                        burstArr[index] = 0;
                    }

                    for (int i = 1; i < p.Length; i++)
                    {
                        if (burstArr[i] > 0 && p[i].arrivalTime <= currentTime && mark[i] == 0)
                        {
                            mark[i] = 1;
                            q.Enqueue(i);
                        }
                    }

                    if (burstArr[index] > 0)
                    {
                        q.Enqueue(index);
                    }

                    if (q.Count == 0)
                    {
                        for (int i = 1; i < p.Length; i++)
                        {
                            if (burstArr[i] > 0)
                            {
                                mark[i] = 1;
                                q.Enqueue(i);
                                break;
                            }
                        }
                    }
                }

                avgWaiting = (float)totalWaiting / p.Length;
                avgTurn = (float)totalTurn / p.Length;
                AvgWaiting.Text = avgWaiting+ "";
                TurnAround.Text = avgTurn + "";

                ls.AddRange(processTimeList);
                int totalTime = 0;
                for (int i = 0; i < processTimeList.Count; i++)
                {
                    if (i == 0)
                    {
                        if (processTimeList[i].arrivalTime > 0)
                        {
                            idleTime = processTimeList[i].arrivalTime;
                            Process pr = new Process();
                            pr.CompletionTime = idleTime;
                            pr.pid = -1;
                            ls.Insert(0, pr);
                            ind++;
                            totalTime += idleTime + processTimeList[i].burstTime;
                        }

                        else
                        {
                            totalTime += processTimeList[i].burstTime;
                        }
                    }

                    else
                    {
                        if (processTimeList[i].arrivalTime > totalTime)
                        {
                            int delay = processTimeList[i].arrivalTime - totalTime;
                            Process idle = new Process();
                            idle.arrivalTime = processTimeList[i - 1].burstTime;
                            idle.burstTime = delay;
                            idle.CompletionTime = idle.burstTime;
                            idle.pid = -1;
                            ls.Insert(i + ind, idle);
                            ind++;
                            totalTime += delay + processTimeList[i].burstTime;

                        }
                        else
                        {
                            totalTime += processTimeList[i].burstTime;
                        }
                    }
                }

                ls = processTimeList;
            }

            else
            {
                MessageBox.Show("Select an algorithm.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            draw(ls);
        }

        private void draw(List<Process> ls)
        {
            Graphics g = panel3.CreateGraphics();
            g.Clear(Color.White);
            Font font = new Font("Manrope", 12);
            int x = 50, y = 50;
            Pen finalPen = new Pen(Color.Black, 1);
            finalPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            g.DrawLine(finalPen, new Point(x, y - 20), new Point(x, y + 20));
            g.DrawString("0", font, Brushes.Black, new Point(x-6, y + 20));
            int counter = 0;
            for (int i = 0; i < ls.Count; i++)
            {
                if (ls[i].pid == -1 || ls[i].pid == 10)
                {
                    counter += ls[i].CompletionTime;
                    g.DrawString(" Idle", font, Brushes.Black, new Point(x, y - 10));
                    x += 50;
                    g.DrawString(counter.ToString(), font, Brushes.Black, new Point(x-6, y + 20));;
                }

                else
                {
                    counter += ls[i].burstTime;
                    g.DrawString("   P" + ls[i].pid, font, Brushes.Black, new Point(x, y - 10));
                    x += 50;
                    g.DrawString(counter.ToString(), font, Brushes.Black, new Point(x-6, y + 20));

                }
                g.DrawLine(finalPen, new Point(x, y - 20), new Point(x, y + 20));

            }


        }

        private void AlgorithmsMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (AlgorithmsMenu.SelectedIndex == 3)
            {
                QValue.Visible = true;
                QLabel.Visible = true;
            }

            else
            {
                QValue.Visible = false;
                QLabel.Visible = false;
            }
        }

        class Process
        {
            public int pid;
            public int arrivalTime;
            public int burstTime;
            public int waitingTime;
            public int turnaroundTime;
            public int CompletionTime;
            public int remainingTime;
            public int turnTime;
            public int startTime;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}