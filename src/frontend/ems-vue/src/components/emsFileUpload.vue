<template>
  <div class="file-upload">
    <label :for="inputId" class="upload-label">
      <img v-if="previewImage" :src="previewImage" alt="Preview" class="preview-image" />
      <span v-else>Browse...</span>
    </label>
    <input :id="inputId" type="file" accept="image/*" @change="handleFileChange" />
  </div>
</template>

<script setup lang="ts">
import { defineProps, ref } from "vue";

const inputId = ref(`file-upload-${Math.random().toString(36).substr(2, 9)}`);
const previewImage = ref("");

const handleFileChange = (event: Event) => {
  const input = event.target as HTMLInputElement;
  if (input.files && input.files[0]) {
    const file = input.files[0];
    const reader = new FileReader();
    reader.onload = () => {
      previewImage.value = reader.result as string;
      props.onFileChange(file);
    };
    reader.readAsDataURL(file);
  }
};
</script>

<style scoped>
.file-upload {
  position: relative;
}

.upload-label {
  display: block;
  width: 350px;
  height: 350px;
  border: 2px dashed #ccc;
  border-radius: 10px;
  text-align: center;
  cursor: pointer;
  margin-bottom: 10px;
}

.preview-image {
  width: 100%;
  height: 100%;
  object-fit: cover;
  border-radius: 10px;
}
</style>
