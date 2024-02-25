IWorker[] workers = new IWorker[3]
{
    new Manager(),
    new Robot(),
    new Worker()
};

IEat[] eat = new IEat[2]
{
    new Manager(),
    new Worker()
};

foreach (var worker in workers)
{
    worker.Work();
}
interface IWorker
{
    void Work();
   
}

interface IEat
{
    void Eat();
}

interface ISalary
{
    void GetSalary();
}



class Manager : IWorker,IEat,ISalary
{
    public void Eat()
    {
        throw new NotImplementedException();
    }

    public void GetSalary()
    {
        throw new NotImplementedException();
    }

    public void Work()
    {
        throw new NotImplementedException();
    }
}

class Worker : IWorker,ISalary,IEat
{
    public void Eat()
    {
        throw new NotImplementedException();
    }

    public void GetSalary()
    {
        throw new NotImplementedException();
    }

    public void Work()
    {
        throw new NotImplementedException();
    }
}

class Robot : IWorker
{
    public void Work()
    {
        throw new NotImplementedException();
    }
}