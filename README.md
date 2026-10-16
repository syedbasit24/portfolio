# Basit Altaf - Portfolio Website

A premium, modern portfolio website built with ASP.NET Core Blazor WebAssembly, showcasing professional experience, skills, and projects.

## 🚀 Features

- **Modern Design**: Dark-first theme with electric blue accents and smooth animations
- **Responsive Layout**: Fully responsive design for desktop, tablet, and mobile devices
- **Interactive Components**: 
  - Sticky navigation with smooth scrolling
  - Project portfolio with filtering and detail modals
  - Animated skill categories and experience timeline
  - Contact form with validation
- **Theme Toggle**: Light/dark theme switcher with localStorage persistence
- **SEO Optimized**: Proper meta tags, Open Graph, and semantic HTML
- **Performance**: Optimized CSS, lazy loading, and efficient animations

## 🛠️ Technology Stack

- **Framework**: ASP.NET Core 9.0 Blazor WebAssembly
- **Language**: C# / .NET
- **Styling**: Custom CSS with CSS variables for theming
- **Icons**: Inline SVG icons (Lucide-style)
- **Animations**: CSS animations with Intersection Observer for scroll effects

## 📋 Prerequisites

- [.NET 9.0 SDK](https://dotnet.microsoft.com/download/dotnet/9.0) or later
- A code editor (Visual Studio 2022, Visual Studio Code, or similar)

## 📦 Installation

1. **Clone or navigate to the project directory**:
   ```bash
   cd D:\MYPORTFOLIO_WEBSITE
   ```

2. **Restore NuGet packages**:
   ```bash
   dotnet restore
   ```

3. **Build the project**:
   ```bash
   dotnet build
   ```

## 🏃 Running the Application

### Development Mode

Run the application with hot reload:

```bash
dotnet run
```

The application will be available at: `http://localhost:5000` (or the port shown in the output)

### Production Build

Create an optimized production build:

```bash
dotnet publish -c Release -o ./publish
```

The published files will be in the `./publish` directory.

## 📁 Project Structure

```
Portfolio/
├── Components/           # Reusable Blazor components
│   ├── About.razor
│   ├── Contact.razor
│   ├── Education.razor
│   ├── Experience.razor
│   ├── Footer.razor
│   ├── Hero.razor
│   ├── Navbar.razor
│   ├── Projects.razor
│   ├── Skills.razor
│   ├── SoftSkills.razor
│   └── Certifications.razor
├── Data/                # Data models and static data
│   ├── ProfileData.cs
│   ├── SkillsData.cs
│   ├── ExperienceData.cs
│   ├── ProjectsData.cs
│   ├── EducationData.cs
│   └── CertificationsData.cs
├── Layout/              # Layout components
│   └── MainLayout.razor
├── Pages/               # Page components
│   └── Home.razor
├── wwwroot/            # Static assets
│   ├── styles/
│   │   └── site.css
│   ├── assets/
│   │   └── README.md   # Place your resume here
│   └── index.html
├── Portfolio.csproj
└── README.md
```

## ⚙️ Configuration

### Adding Your Resume

1. Place your resume PDF in the `wwwroot/assets/` directory
2. Name it exactly: `Basit-Altaf-Resume.pdf`
3. The download link in the Hero section will automatically work

### Updating Contact Form

The contact form currently uses a fallback that opens the user's email client. To enable server-side email sending:

1. Sign up for [EmailJS](https://www.emailjs.com/) or [Resend](https://resend.com/)
2. Update the `Contact.razor` component to integrate with your chosen service
3. See `.env.example` for configuration details

### Customizing Content

All content is centralized in the `Data/` directory:

- **ProfileData.cs**: Personal information, headlines, and descriptions
- **SkillsData.cs**: Technical skills organized by category
- **ExperienceData.cs**: Professional experience timeline
- **ProjectsData.cs**: Project portfolio with details
- **EducationData.cs**: Academic background
- **CertificationsData.cs**: Certifications and training

## 🎨 Customization

### Colors and Theme

Edit the CSS variables in `wwwroot/styles/site.css`:

```css
:root {
    --accent-primary: #3b82f6;
    --accent-secondary: #8b5cf6;
    --accent-cyan: #06b6d4;
    /* ... more variables */
}
```

### Adding New Projects

Add a new project in `Data/ProjectsData.cs`:

```csharp
new()
{
    Id = "project-id",
    Name = "Project Name",
    ShortDescription = "Brief description",
    FullDescription = "Detailed description",
    Technologies = new List<string> { "Tech1", "Tech2" },
    Category = "Category",
    GitHubUrl = "https://github.com/...",
    LiveDemoUrl = "https://...",
    IsExperienceBased = false
}
```

## 🚢 Deployment

### Azure Static Web Apps

1. Create a new Azure Static Web Apps resource
2. Connect to your GitHub repository
3. Configure build settings:
   - **Build Command**: `dotnet publish -c Release -o ./publish`
   - **Build Output Location**: `publish/wwwroot`
   - **Framework**: .NET

### GitHub Pages

1. Build the project: `dotnet publish -c Release -o ./publish`
2. Copy contents of `publish/wwwroot` to your GitHub repository
3. Enable GitHub Pages in repository settings
4. Select the branch and folder

### Vercel (with static export)

1. Build the project: `dotnet publish -c Release -o ./publish`
2. Deploy the `publish/wwwroot` folder to Vercel
3. Configure as a static site

### Traditional Web Hosting

1. Build the project: `dotnet publish -c Release -o ./publish`
2. Upload contents of `publish/wwwroot` to your web host
3. Ensure the host supports static file serving

## 🧪 Testing

### Manual Testing Checklist

- [ ] Navigation links work and scroll smoothly
- [ ] Theme toggle switches between light and dark modes
- [ ] Project filtering works correctly
- [ ] Project detail modals open and close
- [ ] Contact form validation works
- [ ] Resume download button works (after adding resume)
- [ ] All external links open correctly
- [ ] Responsive design on mobile (375px, 768px)
- [ ] Responsive design on tablet (1024px)
- [ ] Responsive design on desktop (1920px)

### Browser Testing

Test in:
- Chrome/Edge (Chromium)
- Firefox
- Safari (if on macOS)

## 📝 Content Updates

### Adding a New Skill Category

1. Add category to `Data/SkillsData.cs`
2. Add icon SVG in `Components/Skills.razor`
3. Update CSS if needed

### Adding New Experience

Add to `Data/ExperienceData.cs` following the existing pattern.

### Adding New Certification

Add to `Data/CertificationsData.cs` following the existing pattern.

## 🔧 Troubleshooting

### Build Errors

If you encounter build errors:

```bash
dotnet clean
dotnet restore
dotnet build
```

### Port Already in Use

If port 5000 is in use, the application will automatically use an available port. Check the console output for the actual URL.

### Styling Not Applied

Ensure `site.css` is in `wwwroot/styles/` and referenced in `index.html`.

## 📄 License

This portfolio is for personal and professional use. Feel free to customize it for your needs.

## 👤 Author

**Basit Altaf**
- Email: sayedbaset28@gmail.com
- LinkedIn: https://www.linkedin.com/in/syedbasit6838351b3
- Location: Delhi, India

## 🙏 Acknowledgments

- Built with ASP.NET Core Blazor
- Inspired by modern developer portfolio designs
- Icons from Lucide (inline SVG implementation)

---

**Note**: This is a portfolio website. Do not invent achievements, skills, or experiences. Keep all information accurate and truthful.
