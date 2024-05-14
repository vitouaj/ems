<template>
  <div class="text-field">
    <label :for="id">{{ label }}</label>
    <input :type="type" :id="id" v-model="inputValue" @input="handleChange" />
    <p v-if="error" class="error">{{ error }}</p>
  </div>
</template>

<script lang="ts">
import { defineComponent, ref, watch } from "vue";
import type { PropType } from "vue";

export default defineComponent({
  name: "emsTextField",
  props: {
    id: {
      type: String,
      required: true,
    },
    label: {
      type: String,
      required: true,
    },
    type: {
      type: String,
      default: "text",
    },
    value: {
      type: String,
      default: "",
    },
    validator: {
      type: Function as PropType<(value: string) => string | null>,
      default: null,
    },
  },
  emits: ["update:value"],
  setup(props, { emit }) {
    const inputValue = ref(props.value);
    const error = ref<string | null>(null);

    watch(inputValue, (newValue) => {
      emit("update:value", newValue);
      if (props.validator) {
        error.value = props.validator(newValue);
      }
    });

    const handleChange = () => {
      if (props.validator) {
        error.value = props.validator(inputValue.value);
      }
    };

    return {
      inputValue,
      error,
      handleChange,
    };
  },
});
</script>

<style scoped>
.text-field {
  margin-bottom: 1rem;
  position: relative;
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
