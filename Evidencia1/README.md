# Evidencia 1: Ejercicios (3-20).

En esta evidencia, se presentan los pasos necesarios para crear y ejecutar proyectos de consola en **C#**.

## Pasos a seguir

### 1. **Abrir la consola**  
Para abrir la consola, usa el siguiente atajo:
- **Ctrl + ñ**

### 2. **Crear un proyecto de consola**
Ejecuta el siguiente comando para crear un proyecto de consola:
```bash
dotnet new console -n ejercicio3
```

### 3. Crear múltiples proyectos de consola en una sola línea de comando
Si deseas crear varios proyectos de consola en una sola línea, puedes usar el siguiente comando:
```bash
for i in {4..20}; do dotnet new console -n ejercicio$i; done
```

### 4. Ingresar a la carpeta del proyecto
Para ingresar a la carpeta del proyecto recién creado, usa el comando:
```bash
cd ejercicio3
```

### 5. Ejecutar el proyecto
Para ejecutar el proyecto, usa:
```bash
dotnet run
```

### ¿Preguntas o sugerencias?
Si tienes alguna duda o sugerencia, no dudes en contactarme o abrir un **pull request.**

**Autor:** Angel Díaz.