const { execSync } = require('child_process');
const fs = require('fs');
const path = require('path');

console.log('Starting build process...');

// Install .NET SDK
console.log('Installing .NET SDK...');
try {
  execSync('curl -sSL https://dot.net/v1/dotnet-install.sh | bash /dev/stdin --channel 9.0 --install-dir /usr/share/dotnet', {
    stdio: 'inherit'
  });
} catch (error) {
  console.error('Failed to install .NET SDK:', error);
  process.exit(1);
}

// Add .NET to PATH
process.env.PATH = '/usr/share/dotnet:' + process.env.PATH;

// Build the project
console.log('Building .NET project...');
try {
  execSync('dotnet publish -c Release -o ./publish', {
    stdio: 'inherit',
    env: process.env
  });
} catch (error) {
  console.error('Build failed:', error);
  process.exit(1);
}

console.log('Build complete!');
