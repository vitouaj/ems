<template>
  <div class="text-field">
    <label :for="id">{{ label }}</label>
    <input :type="type" :id="id" v-model="inputValue" @input="handleChange" />
    <p v-if="error" class="error">{{ error }}</p>
  </div>
</template>

<script setup lang="ts">
import { ref } from "vue";

const props = defineProps<{
  id: string;
  label: string;
  type?: string;
  value?: string;
  validator?: (value: string) => string | null;
}>();

const inputValue = ref(props.value || "");
const error = ref<string | null>(null);

const handleChange = () => {
  if (props.validator) {
    error.value = props.validator(inputValue.value);
  }
};
</script>

<style scoped>
.text-field {
  margin-bottom: 1rem;
}

label {
  display: block;
  margin-bottom: 0.5rem;
}

input {
  width: 100%;
  padding: 0.5rem;
  border: 1px solid #ccc;
  border-radius: 4px;
  font-size: 1rem;
}

.error {
  color: red;
  margin-top: 0.5rem;
}
</style>
