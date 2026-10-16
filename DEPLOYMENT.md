# Deployment Guide

This portfolio can be deployed to various static hosting platforms. Below are instructions for the most popular options.

## Prerequisites

1. Build the project for production:
   ```bash
   dotnet publish -c Release -o ./publish
   ```

2. The built files will be in `publish/wwwroot/`

---

## Option 1: Vercel (Recommended)

### Method A: Using Vercel CLI

1. Install Vercel CLI:
   ```bash
   npm install -g vercel
   ```

2. Login to Vercel:
   ```bash
   vercel login
   ```

3. Deploy:
   ```bash
   vercel --prod
   ```

4. Follow the prompts:
   - Set the project name
   - Set the root directory to `publish/wwwroot`
   - Choose "Other" for framework preset
   - Keep other settings as default

### Method B: Using Vercel Dashboard

1. Go to [vercel.com](https://vercel.com) and sign up/login
2. Click "Add New Project"
3. Import your Git repository or upload the folder
4. Configure:
   - **Framework Preset**: Other
   - **Root Directory**: `publish/wwwroot`
   - **Build Command**: (leave empty)
   - **Output Directory**: (leave empty)
5. Click "Deploy"

### Method C: Manual Drag & Drop

1. Go to [vercel.com](https://vercel.com) and sign up/login
2. Click "Add New Project" → "Upload Files"
3. Upload the entire `publish/wwwroot` folder
4. Click "Deploy"

---

## Option 2: GitHub Pages

### Step 1: Push to GitHub

1. Initialize Git repository (if not already done):
   ```bash
   git init
   git add .
   git commit -m "Initial commit"
   ```

2. Create a new repository on GitHub
3. Add remote and push:
   ```bash
   git remote add origin https://github.com/YOUR_USERNAME/YOUR_REPO.git
   git branch -M main
   git push -u origin main
   ```

### Step 2: Enable GitHub Pages

1. Go to your repository on GitHub
2. Click **Settings** → **Pages**
3. Under **Source**, select:
   - **Branch**: `main`
   - **Folder**: `/ (root)` or `/docs`
4. Click **Save**

### Step 3: Using GitHub Actions (Recommended)

Create `.github/workflows/deploy.yml`:

```yaml
name: Deploy to GitHub Pages

on:
  push:
    branches: [ main ]

jobs:
  deploy:
    runs-on: ubuntu-latest
    
    steps:
    - uses: actions/checkout@v3
    
    - name: Setup .NET
      uses: actions/setup-dotnet@v3
      with:
        dotnet-version: '9.0.x'
    
    - name: Publish
      run: dotnet publish -c Release -o output
    
    - name: Deploy to GitHub Pages
      uses: peaceiris/actions-gh-pages@v3
      with:
        github_token: ${{ secrets.GITHUB_TOKEN }}
        publish_dir: ./output/wwwroot
```

Push this file and GitHub will automatically deploy on every push.

---

## Option 3: Netlify

### Method A: Netlify Drop

1. Go to [app.netlify.com/drop](https://app.netlify.com/drop)
2. Drag and drop the `publish/wwwroot` folder
3. Your site will be live instantly!

### Method B: Netlify CLI

1. Install Netlify CLI:
   ```bash
   npm install -g netlify-cli
   ```

2. Login:
   ```bash
   netlify login
   ```

3. Deploy:
   ```bash
   cd publish/wwwroot
   netlify deploy --prod
   ```

---

## Option 4: Azure Static Web Apps

### Using Visual Studio

1. Right-click the project in Visual Studio
2. Select **Publish**
3. Choose **Azure** → **Azure Static Web Apps**
4. Follow the wizard to create and deploy

### Using Azure CLI

```bash
az staticwebapp create \
  --name your-portfolio-name \
  --resource-group your-resource-group \
  --source . \
  --location eastus \
  --sku Free
```

---

## Post-Deployment Checklist

After deployment, verify:

- [ ] All sections load correctly
- [ ] Navigation links work
- [ ] Contact form submits successfully
- [ ] Resume download works (after adding your PDF)
- [ ] Mobile responsiveness looks good
- [ ] Dark/light theme toggle works
- [ ] Social links open correctly
- [ ] No console errors in browser

---

## Custom Domain (Optional)

### Vercel
1. Go to project settings → Domains
2. Add your custom domain
3. Update DNS records as instructed

### GitHub Pages
1. Go to repository Settings → Pages
2. Add custom domain in "Custom domain" section
3. Update DNS records

### Netlify
1. Go to Site settings → Domain management
2. Add custom domain
3. Update DNS records

---

## Environment Variables

If you need to add environment variables:

### Vercel
- Project Settings → Environment Variables

### Netlify
- Site settings → Environment variables

### GitHub Actions
- Repository Settings → Secrets and variables → Actions

---

## Troubleshooting

### 404 Errors on Refresh
This is common with SPA routing. Add a `_redirects` file to your `wwwroot` folder:

```
/* /index.html 200
```

### Formspree Not Working
- Ensure your Formspree form is configured for the deployed domain
- Check Formspree dashboard for submission logs
- Verify CORS settings in Formspree

### Assets Not Loading
- Check that all paths are relative (not absolute)
- Verify files are in the correct directory structure
- Check browser console for 404 errors

---

## Update Instructions

To update your portfolio after deployment:

1. Make changes to your code
2. Build: `dotnet publish -c Release -o ./publish`
3. Upload the new `publish/wwwroot` folder to your hosting platform
4. Or push to Git (if using CI/CD)

---

## Recommended: Vercel

I recommend **Vercel** for this portfolio because:
- ✅ Free tier with generous limits
- ✅ Automatic HTTPS
- ✅ Fast global CDN
- ✅ Easy deployment
- ✅ Custom domains supported
- ✅ Git integration with automatic deployments
- ✅ Preview deployments for testing changes

## Quick Start with Vercel

```bash
# 1. Build the project
dotnet publish -c Release -o ./publish

# 2. Install Vercel CLI
npm install -g vercel

# 3. Login
vercel login

# 4. Deploy
cd publish/wwwroot
vercel --prod
```

That's it! Your portfolio will be live in seconds.
