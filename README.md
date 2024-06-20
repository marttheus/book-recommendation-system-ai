# Book Recommendation System AI

***
>This project develops a book recommendation system using machine learning algorithms with ML.NET.
>The system analyzes users' reading history and preferences to suggest relevant books.
>Additionally, it offers functionalities such as user registration, book and review logging, personalized recommendations, and notifications.
***

## Technologies
- **Language**: C#
- **Framework**: .NET 8
- **Database**: PostgreSQL
- **Machine Learning**: ML.NET
- **CI/CD**: GitHub Actions
- **Cloud**: Heroku

## Features
- **Authentication and Authorization**: User and role management with ASP.NET Identity, JWT authentication.
- **Book and Review Logging**: CRUD operations for books and reviews using Entity Framework.
- **Recommendation Algorithm**: Collaborative filtering with ML.NET to generate personalized recommendations.
- **Notification System**: Sending notifications for new recommendations via SendGrid.

## Non-Functional Requirements
- **Performance**: Generate recommendations in less than 200ms.
- **Security**: Protection against common attacks (SQL Injection, XSS).
- **Scalability**: Ability to scale horizontally to support increased load.
- **Reliability**: 99.9% availability.
- **Maintainability**: Modular and well-documented code.

## Development Environment Setup

### Required Tools
- Docker
- Docker Compose

### Setup Steps
1. **Clone the repository**:
   ```bash
   git clone https://github.com/marttheus/book_recommendation_system_ai.git
   cd book_recommendation_system_ai
   ```
2. **Set up the local environment**:
   1. Ensure Docker and Docker Compose are installed on your machine.
3. **Start the application using Docker Compose**:
   ```bash
   docker-compose up
   ```
4. **Access the application**:
    1. The application will be running on http://localhost:5000.
    2. PostgreSQL will be accessible on localhost:5432.
    3. pgAdmin will be accessible on http://localhost:5050 (default email: admin@admin.com, password: admin).

## Running the Project
1. Restore packages
   ```bash
    dotnet restore
   ```
2. Apply database migrations
   ```bash
    dotnet ef database update
   ```
3. Run the application
   ```bash
    dotnet run
   ```
## Testing and Quality

### Unit and Integration Tests
- Write tests using xUnit.
- Use mocks and stubs to isolate external dependencies.

### Performance Testing
- Use Apache JMeter to simulate load and measure recommendation response time.

### Security Testing
- Use OWASP ZAP to scan the application for vulnerabilities.

### Scalability Testing
- Use k6 to evaluate system performance under high-demand scenarios.

## Deployment and Monitoring

### Deployment
- Deploy the application to Heroku.
- Configure the deployment pipeline in GitHub Actions for automated deployments.

### Monitoring
- Set up monitoring with the Heroku platform and third-party tools like Grafana and Prometheus.
- Configure alerts using services like Healthchecks.io.

## License
This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.