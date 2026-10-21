const { execSync } = require('child_process');

console.log('Starting build process...');

// Build the project
console.log('Building .NET project...');
try {
  execSync('dotnet publish -c Release -o ./publish', {
    stdio: 'inherit',
    shell: true
  });
} catch (error) {
  console.error('Build failed:', error);
  process.exit(1);
}

console.log('Build complete!');
