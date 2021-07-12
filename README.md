## This file describe my work on the project.

The Goal of the project is to build a school manegmant system.

### Sumary of my work and workflow:

I read the task and the logic didn't seems so complicated, but the deployment/packing of the system looked more chalenging to me, so I started with this.
I 3 evening to the task, and what we have here is what I succeded to perform. I enjoy to take the challenge.
### Self Esteem:
tl;dr:
The task is not "Done". I enjoyed the process.

I learned ".net" as a new framework and composed a docker-compose as part of this task, which is greate.
I didn't get to work on the logic issues, which also means That not much of the code is "mine", since it lots of reaserch of how to make things to work... (It was more "plumbing" work than actually coding).


### Work Done:

- Build .net service with API. Missing: 1. School logic. 2. Connection to db.
- Disabled the "https" access, and remain only with "http" (That took me more time then I wanted to give to it).
- Dockerize: create a "docker-compose.yml" file that define the services: 1. "schoolcycode": .net api. 2. "postgresql": db services.
- Define the tables creation in a script: "sql/create_tables.sql" (Not fully worked yet).
- Add "README.md" that describe my work (Yes, yes, this is the current file :) ).

### Todo:

- Finish the task of make the db init script to create the tables.
- Write logic for CRUD operations in the .net service.
- Write tests for the CRUD operations (There are some edge cases, for example: remove student should update the student list of the course).
- Write logic for the required functionality (calculated fields: "best_student_in_course", "easiest_course")
- Write logic to register a student to specific course.
- Write tests for the above functionality (It's not TDD, but I don't know the framework enough to start the task as TDD...).
- Write the api endpoints and logic for the grade system.
- Fix the "SSL" issue that took lots of my time and finaly decided to skip (I disabled the "https" access, and remain only with "http").

## Links I used:

### Installations:

vs code .net extension:
https://www.youtube.com/watch?v=a6WPeTG1QEk&ab_channel=Jayanam

docker desktop:
https://docs.docker.com/docker-for-windows/install/

.net sdk:
https://dotnet.microsoft.com/download/dotnet/thank-you/sdk-5.0.301-windows-x64-installer


Videos

1. .NET Core 3.1 MVC REST API - Full Course
https://www.youtube.com/watch?v=fmvcAzHpsk8&ab_channel=LesJackson

2. Step by step - Run and Connect to SQL Server in Docker
https://www.youtube.com/watch?v=SJAl3vOX05M&ab_channel=LesJackson

3. Viewed!!!
Deploy a .NET Core API with Docker (Step-by-Step)
https://www.youtube.com/watch?v=f0lMGPB10bM&ab_channel=LesJackson

4. Half viewed.
Docker Compose with .NET Core & SQL Server (Step by Step)
https://www.youtube.com/watch?v=4V7CwC_4oss&ab_channel=LesJackson

5. Viewed !!!
Run ASP.NET Core 3.1 Apps in Docker with HTTPS.
https://www.youtube.com/watch?v=lcaDDxJv260&ab_channel=LesJackson


## Docker commands I used during my work

### Windows work through VS_code

docker .net:
```
cd SchooleCycode
docker build -t schoolcycode .
docker run schoolcycode
```

create certificat for docker:
```
# from cmd:
dotnet dev-certs https -ep C:\Users\rea\.aspnet\https\SchooleCycode.pfx -p pa55w0rd!

cd C:\Users\rea\Documents\dotnet_projectsSchoolCycode
dotnet user-secrets set "Kestrel:Certificates:Development:Password" "pa55w0rd!"

# from vs code:
docker-compose up --build
```

For testing:
```
curl localhost:8080/api/students
```

### Ubuntu commands: (At some point I moved to work on a VM that runs Ubuntu)

docker-compose for postgresql (link):
https://github.com/jdaarevalo/docker_postgres_with_data

Connect to postgresql in docker:
```
docker exec -it schoolcycode_postgres_1 psql -h localhost -U postgres
```

