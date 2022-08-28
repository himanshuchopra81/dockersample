# Running ASP.NET web API in docker container
## Open Terminal(linux/mac) OR CMD(windows)
Navigate to BackEnd/SampleAPI directory and run the below commad
```
docker build . -t sampleapi:1.0
```
This will build the docker image using the DockerFile(present in ./BackEnd/SampleAPI)</br>
```-t : this is used to tag an image```

Now you should see docker image in your local container repository by running 
```
docker image ls
```
Well, after a successful image build, we need to run this image inside a docker container
```
docker run -dp 5000:80 --name myapp sampleapi:1.0
```
Let's break down the command:

```-d, this simply means we run the container in the background.``` </br>

```-p that means we will match an external port to an internal container port.``` </br> 
For some Dockerfile specification you need to explicitly expose an internal port, this is not needed in our case as it runs on port 80. But let's be clear on the syntax external port: internal port. This means we connect our machines port 5000 to the internal container port 80.
</br> 
```--name, this is us giving our container name, myapp. If we don't specify a name one will otherwise be generated for us.```
</br> 
 Having a name makes it easier to reference it later.
Our last argument is the image name sampleapi:1.0

Let's check that our container was created and is running with the command 
```
docker container ps
```

Lastly, let's check that our container is up and running by going to http://localhost:5000
