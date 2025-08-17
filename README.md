# devops-playground
To have hands-on on devops 


# What i learnt about docker image building
Ref: https://docs.docker.com/reference/dockerfile/

writing Dockerfile - creating different stages for build, final for reducing the size of the image
getting base images for different stages - copying the project files from local to docker and building the project
copying the build files from build stage to final stage and finally set the entrypoint or running the built file

now run the Dockerfile using the docker build command using tags to build the image - it has different layers to it,
these layers are cached and will be reused if we try to rebuild
finally the built image is availbale if we see the docker images list
we can now push the image to any container registry - i used github container registry for my purpose

we can use pull commands to pull images from remote - delete images from local docker images list

now to run the image we can run the image using docker run command and the conatiners get created - we can provide a name for container
if we dont provide container name - docker provides its own container name 
it see all the processes running we can use docker ps
to see all completed processes we can use docker ps -a

to delete a container docker rm container name/id
to delete an image docker rmi image name/id

Now docker compose file - docker-compose.yaml
we provide the service with configuration details set in this compose file like env, volumes, secrets, configs, image link
and we simply run docker compose up and the container will be up and running
we can do docker compose down 

we can the compose yaml and we can do the docker compose up and it will pick the latest changes and deploys the container

apart from all this - we can see the history of the image to see different layers that are created as part of the image building
and also the final stage of the dockerfile only will be remained in the image and the rest of the stages will be discarded





# How to push a image to container registry
Ref: https://docs.github.com/en/packages/working-with-a-github-packages-registry/working-with-the-container-registry
export CR_PAT=YOUR_TOKEN
echo $CR_PAT | docker login ghcr.io -u USERNAME --password-stdin
docker push ghcr.io/NAMESPACE/IMAGE_NAME:latest

# using docker-compose 


